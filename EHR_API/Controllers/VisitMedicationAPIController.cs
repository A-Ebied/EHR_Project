using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.VisitMedicationDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/VisitMedicationAPI")]
    [ApiController]
    public class VisitMedicationAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public VisitMedicationAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }

        //[Authorize(Roles = SD.SystemManager + "," + SD.HealthFacilityManager)]
        [HttpPost("CreateVisitMedications")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateVisitMedication([FromBody] VisitMedicationCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._visit.GetAsync(expression: e => e.Id == entityCreateDTO.VisitId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Visit is not exists"));
                }
                if (await _db._medication.GetAsync(expression: e => e.Id == entityCreateDTO.MedicationId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Medication is not exists"));
                }

                var entity = _mapper.Map<VisitMedication>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                await _db._visitMedication.CreateAsync(entity);

                _response.Result = _mapper.Map<VisitMedicationDTOForOthers>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpGet("GetVisitMedications")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetVisitMedications(int visitId)
        {
            try
            {
                var entities = await _db._visitMedication.GetAllAsync(
                    expression: visitId == 0 ? null : g => g.VisitId == visitId);

                if (entities.Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                _response.Result = _mapper.Map<List<VisitMedicationDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpGet("GetVisitMedication")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetVisitMedication(int visitId, int medicationId)
        {
            try
            {
                if (visitId < 1 || medicationId < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var entity = await _db._visitMedication.GetAsync(
                    expression: g => g.MedicationId == medicationId && g.VisitId == visitId);

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {visitId} & {medicationId} "));
                }

                _response.Result = _mapper.Map<VisitMedicationDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.SystemManager + "," + SD.HealthFacilityManager)]
        [HttpPut("UpdateVisitMedication")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateVisitMedication(int visitId, int medicationId, [FromBody] VisitMedicationUpdateDTO entityUpdateDTO)
        {
            try
            {
                if (entityUpdateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (visitId != entityUpdateDTO.VisitId || medicationId != entityUpdateDTO.MedicationId)
                {
                    return BadRequest(APIResponses.BadRequest("Ids is not equal to the Ids of the object"));
                }

                var oldOne = await _db._visitMedication.GetAsync(
                    expression: g => g.VisitId == visitId && g.MedicationId == medicationId);
                if (oldOne == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {visitId} & {medicationId} "));
                }

                if (await _db._visit.GetAsync(expression: e => e.Id == entityUpdateDTO.VisitId) == null)
                {
                    return NotFound(APIResponses.NotFound($"No Visit with Id = {entityUpdateDTO.VisitId}"));
                }
                
                if (await _db._medication.GetAsync(expression: e => e.Id == entityUpdateDTO.MedicationId) == null)
                {
                    return NotFound(APIResponses.NotFound($"No Medication with Id = {entityUpdateDTO.MedicationId}"));
                }

                var entity = _mapper.Map<VisitMedication>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                entity.CreatedAt = oldOne.CreatedAt;
                await _db._visitMedication.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<VisitMedicationDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.SystemManager + "," + SD.HealthFacilityManager)]
        [HttpDelete("DeleteVisitMedication")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteVisitMedication(int visitId, int medicationId)
        {
            try
            {
                if (visitId < 1 || medicationId < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Ids less than 1"));
                }

                var removedEntity = await _db._visitMedication.GetAsync(expression: g => g.VisitId == visitId && g.MedicationId == medicationId);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {visitId} & {medicationId} "));
                }

                await _db._visitMedication.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
    }
}
