using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.UserVaccinationDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/UserVaccinationAPI")]
    [ApiController]
    public class UserVaccinationAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public UserVaccinationAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }

        [HttpPost("CreateUserVaccination")]
        [Authorize(Roles = SD.Physician + "," + SD.HealthFacilityManager)]
        public async Task<ActionResult<APIResponse>> CreateUserVaccination([FromBody] UserVaccinationCreateDTO entityCreateDTO)
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

                if (await _db._vaccination.GetAsync(expression: e => e.Id == entityCreateDTO.VaccinationId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Vaccination is not exists"));
                }

                var entity = _mapper.Map<UserVaccination>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                await _db._userVaccination.CreateAsync(entity);

                _response.Result = _mapper.Map<UserVaccinationDTOForOthers>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize]
        [HttpGet("GetVisitVaccinations")]
        public async Task<ActionResult<APIResponse>> GetVisitVaccinations(int visitId)
        {
            try
            {
                var entities = await _db._userVaccination.GetAllAsync(
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

                    if (headerId != entities[0].Visit.RegistrationDataId && headerRole != SD.Physician & headerRole != SD.HealthFacilityManager && headerRole != SD.SystemManager &&  headerRole != SD.Pharmacist)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                _response.Result = _mapper.Map<List<UserVaccinationDTOForOthers>>(entities);
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
        public async Task<ActionResult<APIResponse>> GetUserVaccination(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var entity = await _db._userVaccination.GetAsync(
                    expression: g => g.Id == id,
                    includeProperties:"Visit");

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

                    if (headerId != entity.Visit.RegistrationDataId && headerRole != SD.Physician & headerRole != SD.HealthFacilityManager && headerRole != SD.SystemManager && headerRole != SD.Pharmacist)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                _response.Result = _mapper.Map<UserVaccinationDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize]
        [HttpGet("GetUserVaccinations")]
        public async Task<ActionResult<APIResponse>> GetUserVaccinations(string userId)
        {
            try
            {
                if (userId == null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var entities = await _db._visit.GetAllAsync(
                    expression: g => g.RegistrationDataId == userId);

                if (entities == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {userId}"));
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

                    if (headerId != entities[0].RegistrationDataId && headerRole != SD.Physician & headerRole != SD.HealthFacilityManager && headerRole != SD.SystemManager && headerRole != SD.Pharmacist)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                var vaccinations = new List<UserVaccination>();
                foreach (var entity in entities)
                {
                    if (entity.UserVaccinations.Count != 0)
                    {
                        vaccinations.AddRange(entity.UserVaccinations);
                    }
                }

                _response.Result = _mapper.Map<List<UserVaccinationDTO>>(vaccinations);
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
        public async Task<ActionResult<APIResponse>> UpdateUserVaccination(int id, [FromBody] UserVaccinationUpdateDTO entityUpdateDTO)
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

                var oldOne = await _db._userVaccination.GetAsync(
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
                
                if (await _db._vaccination.GetAsync(expression: e => e.Id == entityUpdateDTO.VaccinationId) == null)
                {
                    return NotFound(APIResponses.NotFound($"No Vaccination with code = {entityUpdateDTO.VaccinationId}"));
                }

                var entity = _mapper.Map<UserVaccination>(entityUpdateDTO);
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

                    if (headerId != oldOne.Visit.RegistrationDataId)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                await _db._userVaccination.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<UserVaccinationDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = SD.SystemManager)]
        public async Task<ActionResult<APIResponse>> DeleteUserVaccination(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Ids less than 1"));
                }

                var removedEntity = await _db._physicalTherapy.GetAsync(
                    expression: g => g.Id == id);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id}"));
                }

                await _db._physicalTherapy.DeleteAsync(removedEntity);

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
