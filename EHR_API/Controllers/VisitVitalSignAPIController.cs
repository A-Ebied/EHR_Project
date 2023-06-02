using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.VisitVitalSignDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/VisitVitalSignAPI")]
    [ApiController]
    public class VisitVitalSignAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public VisitVitalSignAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }

        [HttpPost("CreateVisitVitalSign")]
        [Authorize(Roles = SD.Physician + "," + SD.HealthFacilityManager)]
        public async Task<ActionResult<APIResponse>> CreateVisitVitalSign([FromBody] VisitVitalSignCreateDTO entityCreateDTO)
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

                var entity = _mapper.Map<VisitVitalSign>(entityCreateDTO);
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

                await _db._visitVital.CreateAsync(entity);

                _response.Result = _mapper.Map<VisitVitalSignDTOForOthers>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize]
        [HttpGet("GetVisitVitalSigns")]
        public async Task<ActionResult<APIResponse>> GetVisitVitalSigns(int visitId)
        {
            try
            {
                var entities = await _db._visitVital.GetAllAsync(
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

                    if (headerId != entities[0].Visit.RegistrationDataId && headerRole != SD.Physician && headerRole != SD.HealthFacilityManager && headerRole != SD.SystemManager)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                _response.Result = _mapper.Map<List<VisitVitalSignDTOForOthers>>(entities);
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
        public async Task<ActionResult<APIResponse>> GetVisitVitalSign(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var entity = await _db._visitVital.GetAsync(
                    expression: g => g.Id == id,
                    includeProperties: "Visit");

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id} "));
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

                    if (headerId != entity.Visit.RegistrationDataId && headerRole != SD.Physician && headerRole != SD.HealthFacilityManager && headerRole != SD.SystemManager)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                _response.Result = _mapper.Map<VisitVitalSignDTO>(entity);
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
        public async Task<ActionResult<APIResponse>> UpdateVisitVitalSign(int id, [FromBody] VisitVitalSignUpdateDTO entityUpdateDTO)
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

                var oldOne = await _db._visitVital.GetAsync(
                    expression: g => g.Id == id,
                    includeProperties: "Visit");

                if (oldOne == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                if (await _db._visit.GetAsync(expression: e => e.Id == entityUpdateDTO.VisitId) == null)
                {
                    return NotFound(APIResponses.NotFound($"No Visit with Id = {entityUpdateDTO.VisitId}"));
                }

                var entity = _mapper.Map<VisitVitalSign>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                entity.CreatedAt = oldOne.CreatedAt;


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

                await _db._visitVital.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<VisitVitalSignDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = SD.SystemManager)]
        public async Task<ActionResult<APIResponse>> DeleteVisitVitalSign(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var removedEntity = await _db._visitVital.GetAsync(expression: g => g.Id == id);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                await _db._visitVital.DeleteAsync(removedEntity);

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
