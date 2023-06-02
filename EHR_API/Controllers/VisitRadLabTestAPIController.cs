using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.VisitRadLabTestDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/VisitRadLabTestAPI")]
    [ApiController]
    public class VisitRadLabTestAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public VisitRadLabTestAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }

        [HttpPost("CreateVisitRadLabTest")]
        [Authorize(Roles = SD.Physician + "," + SD.HealthFacilityManager)]
        public async Task<ActionResult<APIResponse>> CreateVisitRadLabTest([FromBody] VisitRadLabTestCreateDTO entityCreateDTO)
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

                var entity = _mapper.Map<VisitRadLabTest>(entityCreateDTO);
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

                await _db._visitRadLabTest.CreateAsync(entity);

                _response.Result = _mapper.Map<VisitRadLabTestDTOForOthers>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize]
        [HttpGet("GetVisitRadLabTests")]
        public async Task<ActionResult<APIResponse>> GetVisitRadLabTests(int visitId)
        {
            try
            {
                var entities = await _db._visitRadLabTest.GetAllAsync(
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

                    if (headerId != entities[0].Visit.RegistrationDataId && headerRole != SD.Physician && headerRole != SD.HealthFacilityManager && headerRole != SD.SystemManager && headerRole != SD.Technician)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                _response.Result = _mapper.Map<List<VisitRadLabTestDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<APIResponse>> GetVisitRadLabTest(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var entity = await _db._visitRadLabTest.GetAsync(
                    includeProperties: "VisitRadLabResults,Visit",
                    expression: g => g.Id == id);

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id}"));
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

                    if (headerId != entity.Visit.RegistrationDataId && headerRole != SD.Physician && headerRole != SD.HealthFacilityManager && headerRole != SD.SystemManager && headerRole != SD.Technician)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                if (entity.VisitRadLabResults.Count != 0)
                {
                    var temp = new List<RadLabResult>();
                    foreach (var item in entity.VisitRadLabResults)
                    {
                        temp.Add(await _db._radLabResult.GetAsync(
                                    includeProperties: "HealthFacility,RadLabResultImages",
                                    expression: g => g.Id == item.Id));
                    }

                    entity.VisitRadLabResults = temp;
                }

                _response.Result = _mapper.Map<VisitRadLabTestDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpPut("{id}")]
        [Authorize(Roles = SD.Physician + "," + SD.HealthFacilityManager)]
        public async Task<ActionResult<APIResponse>> UpdateVisitRadLabTest(int id, [FromBody] VisitRadLabTestUpdateDTO entityUpdateDTO)
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

                var oldOne = await _db._visitRadLabTest.GetAsync(
                    expression: g => g.Id == id,
                    includeProperties: "Visit");

                if (oldOne == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id}"));
                }

                if (await _db._visit.GetAsync(expression: e => e.Id == entityUpdateDTO.VisitId) == null)
                {
                    return NotFound(APIResponses.NotFound($"No Visit with Id = {entityUpdateDTO.VisitId}"));
                }

                var entity = _mapper.Map<VisitRadLabTest>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                entity.CreatedAt = oldOne.CreatedAt;

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

                    if (headerId != oldOne.Visit.MedicalTeamId)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                await _db._visitRadLabTest.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<VisitRadLabTestDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = SD.SystemManager)]
        public async Task<ActionResult<APIResponse>> DeleteVisitRadLabTest(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Ids less than 1"));
                }

                var removedEntity = await _db._visitRadLabTest.GetAsync(
                    expression: g => g.Id == id);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id}"));
                }

                await _db._visitRadLabTest.DeleteAsync(removedEntity);

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
