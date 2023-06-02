using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.HealthFacilityDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs;
using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/HealthFacilityAPI")]
    [ApiController]
    public class HealthFacilityAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;
        private readonly UserManager<RegistrationData> _userManager;

        public HealthFacilityAPIController(IMainRepository db, IMapper mapper, UserManager<RegistrationData> userManager = null)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
            _userManager = userManager;
        }

        [HttpPost("CreateHealthFacility")]
        [Authorize(Roles = SD.SystemManager + "," + SD.HealthFacilityManager)]
        public async Task<ActionResult<APIResponse>> CreateHealthFacility([FromBody] HealthFacilityCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._healthFacility.GetAsync(expression: g => g.Title!.ToLower() == entityCreateDTO.Title!.ToLower()) != null)
                {
                    return BadRequest(APIResponses.BadRequest("The object is already exists"));
                }

                if (await _db._governorate.GetAsync(expression: e => e.Id == entityCreateDTO.GovernorateId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Governorate is not exists"));
                }

                var entity = _mapper.Map<HealthFacility>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.MedicalTeamId = entityCreateDTO.RegistrationDataId;
                entity.UpdatedAt = DateTime.Now;
                entity.MedicalFacilityTeams = null;

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

                    if (headerId != entityCreateDTO.RegistrationDataId && headerRole != SD.SystemManager)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                await _db._healthFacility.CreateAsync(entity);

                if (entityCreateDTO.MedicalFacilityTeams != null && entityCreateDTO.MedicalFacilityTeams.Count > 0)
                {
                    var facilityTeam = new List<MedicalFacilityTeam>();
                    var temp = new MedicalFacilityTeam();

                    foreach (var item in entityCreateDTO.MedicalFacilityTeams)
                    {
                        temp = _mapper.Map<MedicalFacilityTeam>(item);
                        temp.HealthFacilityId = entity.Id;
                        temp.CreatedAt = DateTime.Now;

                        facilityTeam.Add(temp);
                    }

                    await _db._facilityTeam.CreateRangeAsync(facilityTeam);
                    entity.MedicalFacilityTeams = facilityTeam;
                }

                _response.Result = _mapper.Map<HealthFacilityDTOForOthers>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpGet("GetHealthFacilities")]
        public async Task<ActionResult<APIResponse>> GetHealthFacilities()
        {
            try
            {
                var entities = await _db._healthFacility.GetAllAsync();
                if (entities.Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                _response.Result = _mapper.Map<List<HealthFacilityDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<APIResponse>> GetHealthFacility(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var entity = await _db._healthFacility.GetAsync(
                    expression: g => g.Id == id,
                     includeProperties: "MedicalTeam,MedicalFacilityTeams");

                entity.MedicalTeam = await _db._medicalTeam.GetAsync(
                    expression: r => r.Id == entity.MedicalTeam.Id,
                    includeProperties: "RegistrationData");

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id} "));
                }

                var role = "HealthFacilityManager";
               // role = _userManager.GetRolesAsync(entity.MedicalTeam.RegistrationData).Result.FirstOrDefault();

                UserDTOForOthers manager = APIResponses.User(entity.MedicalTeam.RegistrationData, role);
                var gov = await _db._governorate.GetAsync(
                    expression: g => g.Id == entity.GovernorateId);

                var result = _mapper.Map<HealthFacilityDTO>(entity);
                if (entity.MedicalFacilityTeams != null && entity.MedicalFacilityTeams.Count > 0)
                {
                    var user = new RegistrationData();
                    result.MedicalTeams = new List<UserDTOForOthers>();

                    foreach (var item in entity.MedicalFacilityTeams)
                    {
                        user = await _db._authentication.GetAsync(expression: h => h.Id == item.MedicalTeamId);

                        role = _userManager.GetRolesAsync(user).Result.FirstOrDefault();
                        result.MedicalTeams.Add(APIResponses.User(user, role));
                    }
                }


                result.Manager = manager;
                result.Governorate = gov.Title;
                _response.Result = result;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        [HttpPut("{id}")]
        [Authorize(Roles = SD.SystemManager + "," + SD.HealthFacilityManager)]
        public async Task<ActionResult<APIResponse>> UpdateHealthFacility(int id, [FromBody] HealthFacilityUpdateDTO entityUpdateDTO)
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

                var oldOne = await _db._healthFacility.GetAsync(expression: g => g.Id == id);
                if (oldOne == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                var temp = await _db._healthFacility.GetAsync(expression: g => g.Title!.ToLower() == entityUpdateDTO.Title!.ToLower());
                if (temp != null && id != temp.Id)
                {
                    return BadRequest(APIResponses.BadRequest("The object is already exists"));
                }

                if (await _db._governorate.GetAsync(expression: e => e.Id == entityUpdateDTO.GovernorateId) == null)
                {
                    return NotFound(APIResponses.NotFound($"No Governorate with Id = {entityUpdateDTO.GovernorateId}"));
                }

                if (await _db._authentication.GetAsync(expression: e => e.Id == entityUpdateDTO.RegistrationDataId) == null)
                {
                    return NotFound(APIResponses.NotFound($"No User with Id = {entityUpdateDTO.RegistrationDataId}"));
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

                    if (headerId != entityUpdateDTO.RegistrationDataId && entityUpdateDTO.RegistrationDataId != oldOne.MedicalTeamId && headerRole != SD.SystemManager)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                var entity = _mapper.Map<HealthFacility>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                entity.CreatedAt = oldOne.CreatedAt;
                entity.MedicalTeamId = entityUpdateDTO.RegistrationDataId;

                await _db._healthFacility.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<HealthFacilityDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        [HttpDelete("{id}")]
        [Authorize(Roles = SD.SystemManager)]
        public async Task<ActionResult<APIResponse>> DeleteHealthFacility(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var removedEntity = await _db._healthFacility.GetAsync(expression: g => g.Id == id);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                await _db._healthFacility.DeleteAsync(removedEntity);

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
