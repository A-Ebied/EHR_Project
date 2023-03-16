using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.SurgeryProgressNoteDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/SurgeryProgressNoteAPI")]
    [ApiController]
    public class SurgeryProgressNoteAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public SurgeryProgressNoteAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }


        //[Authorize]
        [HttpGet("GetSurgery")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetSurgery(int surgeryId)
        {
            try
            {
                if (surgeryId == 0)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var entities = await _db._surgeryProgressNote.GetAllAsync(
                    expression: g => g.SurgeryId == surgeryId);
                if (entities.Count == 0)
                {
                    return BadRequest(APIResponses.BadRequest($"No objects with Id = {surgeryId} "));
                }

                _response.Result = _mapper.Map<List<SurgeryProgressNoteDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpGet("GetSurgeryProgressNote")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetSurgeryProgressNote(int id,string medicalTeamId,int surgeryId)
        {
            try
            {
                if (id == 0  || medicalTeamId==null || surgeryId ==0)
                {
                    return BadRequest(APIResponses.BadRequest("Ids are Null"));
                }

                var entity = await _db._surgeryProgressNote.GetAsync(
                    expression: g => g.Id == id && g.MedicalTeamId==medicalTeamId && g.SurgeryId == surgeryId);

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Ids = {id} and {medicalTeamId} and {surgeryId} "));
                }

                _response.Result = _mapper.Map<SurgeryProgressNoteDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        //[Authorize]
        [HttpPost("CreateSurgeryProgressNote")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateSurgeryProgressNote([FromBody] SurgeryProgressNoteCreateDTO entityCreateDTO)
        {
            try
            {

                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }
                //foreach (var item in entityCreateDTO.SurgeryProgressNotes)
                //{

                    if (await _db._surgeryProgressNote.GetAsync(expression: e => e.Id == entityCreateDTO.Id) == null)
                    {
                        return BadRequest(APIResponses.BadRequest("ID is not exists"));
                    }

                    if (await _db._surgery.GetAsync(expression: e => e.Id == entityCreateDTO.SurgeryId) == null)
                    {
                        return BadRequest(APIResponses.BadRequest("SurgeryId is not exists"));
                    }

                    if (await _db._medicalTeam.GetAsync(expression: e => e.Id == entityCreateDTO.MedicalTeamId) == null)
                    {
                        return BadRequest(APIResponses.BadRequest("SurgeryId is not exists"));
                    }
                //}

                var entities = _mapper.Map<List<SurgeryProgressNote>>(entityCreateDTO/*.SurgeryProgressNotes*/);
                foreach (var item in entities)
                {
                    item.Date = DateTime.Now;
                }
                await _db._surgeryProgressNote.CreateRangeAsync(entities);

                _response.Result = _mapper.Map<SurgeryProgressNoteDTO>(entities);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        //[Authorize]
        [HttpDelete("DeleteSurgeryProgressNote")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteSurgeryProgressNote(int id, string medicalTeamId, int surgeryId)
        {
            try
            {
                if (id == 0 || medicalTeamId == null || surgeryId == 0)
                {
                    return BadRequest(APIResponses.BadRequest("Ids are Null"));
                }

                var removedEntity = await _db._surgeryProgressNote.GetAsync(
                    expression: g => g.Id == id && g.MedicalTeamId == medicalTeamId && g.SurgeryId == surgeryId);

                if (removedEntity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Ids = {id} and {medicalTeamId} and {surgeryId} "));
                }

                await _db._surgeryProgressNote.DeleteAsync(removedEntity);

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
        [HttpPut("UpdateSurgeryProgressNote")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateSurgeryProgressNote(int id, string medicalTeamId, int surgeryId, [FromBody] SurgeryProgressNoteUpdateDTO entityUpdateDTO)
        {
            try
            {
                if (entityUpdateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (id != entityUpdateDTO.Id )
                {
                    return BadRequest(APIResponses.BadRequest("Id is not equal to the Id of the object"));
                }

                if (await _db._surgeryProgressNote.GetAsync(
                    expression: g => g.Id == id && g.MedicalTeamId == medicalTeamId && g.SurgeryId == surgeryId)  == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} and {medicalTeamId} and {surgeryId}"));
                }

                var entity = _mapper.Map<SurgeryProgressNote>(entityUpdateDTO);
                entity.Date = DateTime.Now;
                await _db._surgeryProgressNote.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<SurgeryProgressNoteDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);

            }
        }
    }
}
