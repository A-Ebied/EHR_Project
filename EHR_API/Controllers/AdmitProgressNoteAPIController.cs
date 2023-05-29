using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.AdmitProgressNoteDTOs;
using EHR_API.Entities.DTOs.SurgeryProgressNoteDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/AdmitProgressNoteAPI")]
    [ApiController]
    public class AdmitProgressNoteAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public AdmitProgressNoteAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }


        //[Authorize]
        [HttpGet("GetAdmitProgressNotes")]
        public async Task<ActionResult<APIResponse>> GetAdmitProgressNotes(int admitId)
        {
            try
            {
                if (admitId == 0)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var entities = await _db._admitProgressNote.GetAllAsync(expression: g => g.AdmitId == admitId);
                if (entities.Count == 0)
                {
                    return BadRequest(APIResponses.BadRequest($"No objects with Id = {admitId} "));
                }

                _response.Result = _mapper.Map<List<AdmitProgressNoteDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpGet("GetAdmitProgressNote")]
        public async Task<ActionResult<APIResponse>> GetAdmitProgressNote(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest(APIResponses.BadRequest("Id is Null"));
                }

                var entity = await _db._admitProgressNote.GetAsync(expression: g => g.Id == id);
                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id}"));
                }

                _response.Result = _mapper.Map<AdmitProgressNoteDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        //[Authorize]
        [HttpPost("CreateAdmitProgressNote")]
        public async Task<ActionResult<APIResponse>> CreateAdmitProgressNote([FromForm] AdmitProgressNoteCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._admitProgressNote.GetAsync(expression: e => e.Id == entityCreateDTO.Id) == null)
                {
                    return BadRequest(APIResponses.BadRequest("ID is not exists"));
                }

                if (await _db._admit.GetAsync(expression: e => e.Id == entityCreateDTO.AdmitId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Admit Id is not exists"));
                }

                if (await _db._medicalTeam.GetAsync(expression: e => e.Id == entityCreateDTO.MedicalTeamId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Medical Member is not exists"));
                }


                var entity = _mapper.Map<AdmitProgressNote>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;

                await _db._admitProgressNote.CreateAsync(entity);

                _response.Result = _mapper.Map<AdmitProgressNoteDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        //[Authorize]
        [HttpDelete("DeleteAdmitProgressNote")]
        public async Task<ActionResult<APIResponse>> DeleteAdmitProgressNote(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest(APIResponses.BadRequest("Id is Null"));
                }

                var removedEntity = await _db._admitProgressNote.GetAsync(expression: g => g.Id == id);
                if (removedEntity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id}"));
                }

                await _db._admitProgressNote.DeleteAsync(removedEntity);

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
        [HttpPut("UpdateAdmitProgressNote")]
        public async Task<ActionResult<APIResponse>> UpdateAdmitProgressNote(int id, [FromForm] AdmitProgressNoteUpdateDTO entityUpdateDTO)
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

                var oldOne = await _db._admitProgressNote.GetAsync(expression: g => g.Id == id);
                if (oldOne == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id}"));
                }

                var entity = _mapper.Map<AdmitProgressNote>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                entity.CreatedAt = oldOne.CreatedAt;

                await _db._admitProgressNote.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<AdmitProgressNoteDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);

            }
        }
    }
}
