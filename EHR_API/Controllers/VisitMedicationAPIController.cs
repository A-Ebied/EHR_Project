using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.VisitMedicationDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
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

        [HttpPost("CreateVisitMedication")]
        [Authorize(Roles = SD.HealthFacilityManager + "," + SD.Physician)]
        public async Task<ActionResult<APIResponse>> CreateVisitMedication([FromBody] VisitMedicationCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                var visit = await _db._visit.GetAsync(expression: e => e.Id == entityCreateDTO.VisitId);
                if (visit == null)
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

                string jwtToken = null;
                if (HttpContext.Request.Headers.Authorization.Count > 0)
                {
                    jwtToken = HttpContext.Request.Headers.Authorization.ToString().Split(" ")[1];
                }

                string headerId = null;

                if (jwtToken != null)
                {
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerId = user.Claims.ToList()[0].Value;

                    if (headerId != visit.MedicalTeamId)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

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

        [Authorize]
        [HttpGet("GetVisitMedications")]
        public async Task<ActionResult<APIResponse>> GetVisitMedications(int visitId)
        {
            try
            {
                var entities = await _db._visitMedication.GetAllAsync(
                    expression: visitId == 0 ? null : g => g.VisitId == visitId,
                    includeProperties: "Visit");

                if (entities.Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                string jwtToken = null;
                if (HttpContext.Request.Headers.Authorization.Count > 0)
                {
                    jwtToken = HttpContext.Request.Headers.Authorization.ToString().Split(" ")[1];
                }

                string headerRole = null;
                string headerId = null;

                if (jwtToken != null)
                {
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerRole = user.Claims.ToList()[4].Value;
                    headerId = user.Claims.ToList()[0].Value;

                    if (headerId != entities[0].Visit.RegistrationDataId && headerRole != SD.Physician && headerRole != SD.HealthFacilityManager && headerRole != SD.SystemManager && headerRole != SD.Pharmacist)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
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
        
        [Authorize]
        [HttpGet("GetVisitMedication")]
        public async Task<ActionResult<APIResponse>> GetVisitMedication(int visitId, int medicationId)
        {
            try
            {
                if (visitId < 1 || medicationId < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var entity = await _db._visitMedication.GetAsync(
                    expression: g => g.MedicationId == medicationId && g.VisitId == visitId,
                    includeProperties: "Visit");

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {visitId} & {medicationId} "));
                }

                string jwtToken = null;
                if (HttpContext.Request.Headers.Authorization.Count > 0)
                {
                    jwtToken = HttpContext.Request.Headers.Authorization.ToString().Split(" ")[1];
                }

                string headerRole = null;
                string headerId = null;

                if (jwtToken != null)
                {
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerRole = user.Claims.ToList()[4].Value;
                    headerId = user.Claims.ToList()[0].Value;

                    if (headerId != entity.Visit.RegistrationDataId && headerRole != SD.Physician && headerRole != SD.HealthFacilityManager && headerRole != SD.SystemManager && headerRole != SD.Pharmacist)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
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

        [HttpPut("UpdateVisitMedication")]
        [Authorize(Roles = SD.HealthFacilityManager + "," + SD.Physician)]
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
                    return BadRequest(APIResponses.BadRequest("Ids are not equal to the Ids of the object"));
                }

                var oldOne = await _db._visitMedication.GetAsync(
                    expression: g => g.VisitId == visitId && g.MedicationId == medicationId,
                    includeProperties: "Visit");

                if (oldOne == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {visitId} & {medicationId} "));
                }

                string jwtToken = null;
                if (HttpContext.Request.Headers.Authorization.Count > 0)
                {
                    jwtToken = HttpContext.Request.Headers.Authorization.ToString().Split(" ")[1];
                }

                string headerRole = null;
                string headerId = null;

                if (jwtToken != null)
                {
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerRole = user.Claims.ToList()[4].Value;
                    headerId = user.Claims.ToList()[0].Value;

                    if (headerId != oldOne.Visit.MedicalTeamId)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
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

        [Authorize(Roles = SD.SystemManager)]
        [HttpDelete("DeleteVisitMedication")]
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
