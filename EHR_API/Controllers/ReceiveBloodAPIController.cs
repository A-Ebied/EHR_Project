using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.ReceiveBloodDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;


namespace EHR_API.Controllers
{
    [Route("api/ReceiveBloodAPI")]
    [ApiController]
    public class ReceiveBloodAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public ReceiveBloodAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }
         
       // [Authorize]
        [HttpGet("GetUserReceiveBlood")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetUserReceiveBlood(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var entities = await _db._receiveBlood.GetAllAsync(
                    expression: g => g.Id == id);
                if (entities.Count == 0)
                {
                    return BadRequest(APIResponses.BadRequest($"No objects with Id = {id} "));
                }

                _response.Result = _mapper.Map<List<ReceiveBloodDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpGet("GetReceiveBlood")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetReceiveBlood(int id, string userId ,int admitId)
        {
            try
            {
                if (id==0||userId==null|| admitId ==0 )
                {
                    return BadRequest(APIResponses.BadRequest("Ids is NULl "));
                }

                var entities = await _db._receiveBlood.GetAllAsync(
                    expression: g => g.Id ==id && g.RegistrationDataId == userId && g.AdmitId==admitId);

                if (entities==null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id} and {userId} and {admitId}"));
                }

                _response.Result = _mapper.Map<List<ReceiveBloodDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        ////[Authorize]
        [HttpPost("CreateReceiveBlood")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateReceiveBlood([FromBody] ReceiveBloodCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._authentication.GetAsync(expression: e => e.Id == entityCreateDTO.RegistrationDataId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("User is not exists"));
                }

                if (await _db._visit.GetAsync(expression: e => e.Id== entityCreateDTO.AdmitId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("AdmitId is not exists"));
                }

                var entity = _mapper.Map<ReceiveBlood>(entityCreateDTO);
                //entity.CreatedAt = DateTime.Now;
                //entity.UpdatedAt = DateTime.Now;
                entity.DateTime = DateTime.Now;
                await _db._receiveBlood.CreateAsync(entity);

                if (entityCreateDTO.ReceivesBloodData != null)
                {
                    await _db._receiveBloodData.CreateRangeAsync(
                        _mapper.Map<List<ReceiveBloodData>>(entityCreateDTO.ReceivesBloodData.ToList()));
                }

                _response.Result = _mapper.Map<ReceiveBloodDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        ////[Authorize]
        [HttpDelete("DeleteReceiveBlood")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteReceiveBlood(int id, string userId, int admitId)
        {
            try
            {
                if (id == 0 || userId == null || admitId == 0)
                {
                    return BadRequest(APIResponses.BadRequest("Invalid Ids"));
                }

                var removedEntity = await _db._receiveBlood.GetAsync(
                    expression: g => g.Id == id && g.RegistrationDataId == userId && g.AdmitId == admitId);

                if (removedEntity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with  {id} and {userId} and {admitId}"));
                }

                await _db._receiveBlood.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = "The object has been deleted";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
    }
}
