using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.SurgeryDTOs;
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
        public async Task<ActionResult<APIResponse>> GetUserSurgeryies(string userId)
        {
            try
            {
                if (userId == null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var temp = await _db._admit.GetAllAsync(
                    expression: g => g.RegistrationDataId == userId,
                    includeProperties: "Surgeries");
                 
                if (temp.Count == 0)
                {
                    return BadRequest(APIResponses.BadRequest($"No objects with Id = {userId} "));
                }

                var entities = new List<Surgery>();
                foreach (var item in temp)
                {
                    if (item.Surgeries != null && item.Surgeries.Count != 0)
                    {
                        entities.AddRange(item.Surgeries);
                    }
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
        [HttpGet("{id}")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetSurgery(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id is < 1 "));
                }

                var entity = await _db._surgery.GetAsync(
                    includeProperties: "SurgeryProgressNotes",
                    expression: g => g.Id == id);

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id}"));
                }

                _response.Result = _mapper.Map<SurgeryDTO>(entity);
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

                if (await _db._medicalTeam.GetAsync(expression: e => e.Id == entityCreateDTO.MedicalTeamId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("The Medical member is not exists"));
                }

                if (await _db._admit.GetAsync(expression: e => e.Id == entityCreateDTO.AdmitId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Admit is not exists"));
                }

                var entity = _mapper.Map<Surgery>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                entity.SurgeryProgressNotes = null;

                await _db._surgery.CreateAsync(entity);

                //if (entityCreateDTO.SurgeryProgressNotes.Count > 0)
                //{
                //    var progressNotes = new List<SurgeryProgressNote>();
                //    var temp = new SurgeryProgressNote();

                //    foreach (var item in entityCreateDTO.SurgeryProgressNotes)
                //    {
                //        temp = _mapper.Map<SurgeryProgressNote>(item);
                //        temp.SurgeryId = entity.Id;
                //        temp.CreatedAt = DateTime.Now;
                //        temp.UpdatedAt = DateTime.Now;

                //        progressNotes.Add(temp);
                //    }

                //    await _db._surgeryProgressNote.CreateRangeAsync(progressNotes);
                //    entity.SurgeryProgressNotes = progressNotes;
                //}

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
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteSurgery(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Invalid Id"));
                }

                var removedEntity = await _db._surgery.GetAsync(expression: g => g.Id == id);
                if (removedEntity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with  {id}"));
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
        [HttpPut("{id}")]
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

                var oldEntity = await _db._surgery.GetAsync(expression: g => g.Id == id);
                if (oldEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                if (await _db._medicalTeam.GetAsync(expression: e => e.Id == entityUpdateDTO.MedicalTeamId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("The Medical member is not exists"));
                }

                if (await _db._admit.GetAsync(expression: e => e.Id == entityUpdateDTO.AdmitId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Admit is not exists"));
                }

                var entity = _mapper.Map<Surgery>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                entity.CreatedAt = oldEntity.CreatedAt;

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
