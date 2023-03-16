using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.SurgeryDTOs;
using EHR_API.Entities.DTOs.SurgeryProgressNoteDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/SurgeryAPI")]
    [ApiController]
    public class SurgeryAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public SurgeryAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }


        //[Authorize]
        [HttpGet("GetUserSurgeryies")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetUserSurgeryies(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var entities = await _db._surgery.GetAllAsync(
                    expression: g => g.Id == id);

                if (entities.Count == 0)
                {
                    return BadRequest(APIResponses.BadRequest($"No objects with Id = {id} "));
                }

                _response.Result = _mapper.Map<List<SurgeryDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpGet("GetSurgery")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetSurgery(int id,string medicalTeamId,int admitId)
        {
            try
            {
                if (id == 0 || medicalTeamId == null || admitId == 0)
                {
                    return BadRequest(APIResponses.BadRequest("Ids is NULl "));
                }

                var entities = await _db._surgery.GetAllAsync(
                    expression: g => g.Id == id && g.MedicalTeamId == medicalTeamId && g.AdmitId == admitId);

                if (entities == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id} and {medicalTeamId} and {admitId}"));
                }

                _response.Result = _mapper.Map<List<SurgeryDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpPost("CreateSurgery")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateSurgery([FromBody] SurgeryCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._medicalTeam.GetAsync(expression: e => e.Id.ToLower() == entityCreateDTO.MedicalTeamId.ToLower()) != null)
                {
                    return BadRequest(APIResponses.BadRequest("The object is already exists"));
                }

                if (await _db._visit.GetAsync(expression: e => e.Id == entityCreateDTO.AdmitId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("AdmitId is not exists"));
                }

                var entity = _mapper.Map<Surgery>(entityCreateDTO);
                //entity.CreatedAt = DateTime.Now;
                //entity.UpdatedAt = DateTime.Now;
                entity.Date = DateTime.Now;
                await _db._surgery.CreateAsync(entity);

                // Come Back After Create SurgeryProgressNoteDTOs 

                if (entityCreateDTO.SurgeryProgressNotes != null)
                {
                    await _db._surgeryProgressNote.CreateRangeAsync(
                        _mapper.Map<List<SurgeryProgressNote>>(entityCreateDTO.SurgeryProgressNotes.ToList()));
                }

                _response.Result = _mapper.Map<SurgeryDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        //[Authorize]
        [HttpDelete("DeleteSurgery")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteSurgery(int id, string medicalTeamId, int admitId)
        {
            try
            {
                if (id == 0 || medicalTeamId == null || admitId == 0)
                {
                    return BadRequest(APIResponses.BadRequest("Invalid Ids"));
                }

                var removedEntity = await _db._surgery.GetAsync(
                    expression: g => g.Id == id && g.MedicalTeamId == medicalTeamId && g.AdmitId == admitId);

                if (removedEntity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with  {id} and {medicalTeamId} and {admitId}"));
                }

                await _db._surgery.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = "The object has been deleted";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpPut("UpdateSurgery")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateSurgery(int id, [FromBody] SurgeryUpdateDTO entityUpdateDTO)
        {
            try
            {
                if (entityUpdateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (id != entityUpdateDTO.Id)
                {
                    return BadRequest(APIResponses.BadRequest("Id is not equal to the Id of the object"));
                }

                if (await _db._surgery.GetAsync(expression: g => g.Id == id) == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                if (await _db._surgery.GetAsync(expression: e => e.MedicalTeamId == entityUpdateDTO.MedicalTeamId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("MedicalTeamId is not exists"));
                }
                if (await _db._surgery.GetAsync(expression: e => e.AdmitId == entityUpdateDTO.AdmitId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("AdmitId is not exists"));
                }

                var entity = _mapper.Map<Surgery>(entityUpdateDTO);
                entity.Date = DateTime.Now;
                await _db._surgery.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<SurgeryDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
    }
}
