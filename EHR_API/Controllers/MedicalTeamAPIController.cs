using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.HealthFacilityDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.MedicalTeamDTOs;
using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/MedicalTeamAPI")]
    [ApiController]
    public class MedicalTeamAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;
        private readonly UserManager<RegistrationData> _userManager;

        public MedicalTeamAPIController(IMainRepository db, IMapper mapper, UserManager<RegistrationData> userManager)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
            _userManager = userManager;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<APIResponse>> GetMedicalMember(string userId)
        {
            try
            {
                if (userId == null)
                {
                    return BadRequest(APIResponses.BadRequest("User Id is null"));
                }

                var entity = await _db._medicalTeam.GetAsync(
                    expression: g => g.Id == userId,
                    includeProperties: "MedicalFacilityTeams");

                if (entity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with User Id = {userId} "));
                }

                var result = _mapper.Map<MedicalTeamDTO>(entity);
                if (entity.MedicalFacilityTeams != null && entity.MedicalFacilityTeams.Count > 0)
                {
                    result.MedicalFacilities = new List<HealthFacilityDTOForOthers>();
                    foreach (var item in entity.MedicalFacilityTeams)
                    {
                        result.MedicalFacilities.Add(_mapper.Map<HealthFacilityDTOForOthers>(await _db._healthFacility.GetAsync(
                            expression: h => h.Id == item.HealthFacilityId)));
                    }
                }

                _response.Result = result;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpPost("CreateMedicalTeamUser")]
        [Authorize(Roles = SD.HealthFacilityManager + "," + SD.SystemManager)]
        public async Task<ActionResult<APIResponse>> CreateMedicalTeamUser([FromBody] MedicalTeamCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                IEnumerable<string> roles = await _userManager.GetRolesAsync(await _db._authentication.GetAsync(expression: g => g.Id.ToLower() == entityCreateDTO.Id.ToLower()));

                if (roles.Contains("SystemManager") == true || roles.Contains("Patient") == true)
                {
                    return BadRequest(APIResponses.BadRequest("The object is not a medical member"));
                }

                if (await _db._medicalTeam.GetAsync(expression: g => g.Id.ToLower() == entityCreateDTO.Id.ToLower()) != null)
                {
                    return BadRequest(APIResponses.BadRequest("The object is already exists"));
                }

                string jwtToken = null;
                if (HttpContext.Request.Headers.Authorization.Count > 0)
                {
                    jwtToken = HttpContext.Request.Headers.Authorization.ToString().Split(" ")[1];
                }

                string headerRole = null;
                string headerId = null;
                var entity = _mapper.Map<MedicalTeam>(entityCreateDTO);
                if (jwtToken != null)
                {
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerRole = user.Claims.ToList()[4].Value;
                    headerId = user.Claims.ToList()[0].Value;

                    var role = _userManager.GetRolesAsync(
                        await _db._authentication.GetAsync(
                            a => a.Id == entityCreateDTO.Id)).Result.FirstOrDefault();

                    if (headerRole == SD.HealthFacilityManager && role == SD.HealthFacilityManager)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                entity.MedicalFacilityTeams = null;

                await _db._medicalTeam.CreateAsync(entity);

                if (entityCreateDTO.MedicalFacilityTeams != null && entityCreateDTO.MedicalFacilityTeams.Count > 0)
                {
                    var facilityTeam = new List<MedicalFacilityTeam>();
                    var temp = new MedicalFacilityTeam();

                    foreach (var item in entityCreateDTO.MedicalFacilityTeams)
                    {
                        temp = _mapper.Map<MedicalFacilityTeam>(item);
                        temp.MedicalTeamId = entity.Id;
                        temp.CreatedAt = DateTime.Now;

                        facilityTeam.Add(temp);
                    }

                    await _db._facilityTeam.CreateRangeAsync(facilityTeam);
                    entity.MedicalFacilityTeams = facilityTeam;
                }


                _response.Result = _mapper.Map<MedicalTeamDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[HttpDelete("{userId}")]
        //[Authorize(Roles = SD.SystemManager)]
        //public async Task<ActionResult<APIResponse>> DeleteMedicalTeamUser(string userId)
        //{
        //    try
        //    {
        //        if (userId == null)
        //        {
        //            return BadRequest(APIResponses.BadRequest("Id is null"));
        //        }

        //        var removedEntity = await _db._medicalTeam.GetAsync(expression: g => g.Id == userId);
        //        if (removedEntity == null)
        //        {
        //            return NotFound(APIResponses.NotFound($"No object with Id = {userId} "));
        //        }

        //        await _db._medicalTeam.DeleteAsync(removedEntity);

        //        _response.StatusCode = HttpStatusCode.OK;
        //        _response.Result = "The object has been deleted";
        //        return Ok(_response);
        //    }
        //    catch (Exception ex)
        //    {
        //        return APIResponses.InternalServerError(ex);
        //    }
        //}

        [HttpPut("{userId}")]
        [Authorize(Roles = SD.HealthFacilityManager + "," + SD.SystemManager)]
        public async Task<ActionResult<APIResponse>> UpdateMedicalTeamUser(string userId, [FromBody] MedicalTeamUpdateDTO entityUpdateDTO)
        {
            try
            {
                if (entityUpdateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (userId != entityUpdateDTO.Id)
                {
                    return BadRequest(APIResponses.BadRequest("Id is not equal to the Id of the object"));
                }

                var oldOne = await _db._medicalTeam.GetAsync(expression: g => g.Id == userId);
                if (oldOne == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {userId} "));
                }

                string jwtToken = null;
                if (HttpContext.Request.Headers.Authorization.Count > 0)
                {
                    jwtToken = HttpContext.Request.Headers.Authorization.ToString().Split(" ")[1];
                }

                string headerRole = null;
                string headerId = null;
                var entity = _mapper.Map<MedicalTeam>(entityUpdateDTO);
                if (jwtToken != null)
                {
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerRole = user.Claims.ToList()[4].Value;
                    headerId = user.Claims.ToList()[0].Value;

                    var role = _userManager.GetRolesAsync(
                        await _db._authentication.GetAsync(
                            a => a.Id == entityUpdateDTO.Id)).Result.FirstOrDefault();

                    if (headerRole == SD.HealthFacilityManager && role == SD.HealthFacilityManager)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                entity.UpdatedAt = DateTime.Now;
                entity.CreatedAt = oldOne.CreatedAt;
                await _db._medicalTeam.UpdateAsync(entity);


                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<MedicalTeamDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
    }
}
