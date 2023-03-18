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
        public async Task<ActionResult<APIResponse>> GetUserReceiveBlood(string userId)
        {
            try
            {
                if (userId == null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var entities = await _db._admit.GetAllAsync(
                    includeProperties: "ReceiveBloods",
                    expression: g => g.RegistrationDataId == userId);

                if (entities.Count == 0)
                {
                    return BadRequest(APIResponses.BadRequest($"No objects with Id = {userId} "));
                }

                var receives = new List<ReceiveBlood>();
                foreach (var entity in entities)
                {
                    if (entity.ReceiveBloods.Count > 0)
                    {
                        receives.AddRange(entity.ReceiveBloods);
                    }
                }

                _response.Result = _mapper.Map<List<ReceiveBloodDTOForOthers>>(receives);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpGet("{id}")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetReceiveBlood(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id is < 1 "));
                }

                var entity = await _db._receiveBlood.GetAsync(
                    includeProperties: "ReceivesBloodData",
                    expression: g => g.Id ==id);

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id}"));
                }

                _response.Result = _mapper.Map<ReceiveBloodDTOForOthers>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        //[Authorize]
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

                if (await _db._admit.GetAsync(expression: e => e.Id== entityCreateDTO.AdmitId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Admit is not exists"));
                }

                var entity = _mapper.Map<ReceiveBlood>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                entity.ReceivesBloodData = null;

                await _db._receiveBlood.CreateAsync(entity);

                if (entityCreateDTO.ReceivesBloodData.Count > 0)
                {
                    var receivesData = new List<ReceiveBloodData>();
                    var temp = new ReceiveBloodData();

                    foreach (var item in entityCreateDTO.ReceivesBloodData)
                    {
                        temp = _mapper.Map<ReceiveBloodData>(item);
                        temp.ReceiveBloodId = entity.Id;
                        temp.CreatedAt = DateTime.Now;
                        temp.UpdatedAt = DateTime.Now;

                        receivesData.Add(temp);
                    }

                    await _db._receiveBloodData.CreateRangeAsync(receivesData);
                    entity.ReceivesBloodData = receivesData;
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


        //[Authorize]
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteReceiveBlood(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Invalid Id"));
                }

                var removedEntity = await _db._receiveBlood.GetAsync(
                    expression: g => g.Id == id);

                if (removedEntity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with  {id}"));
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
