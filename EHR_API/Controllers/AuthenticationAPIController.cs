using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Login;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_API.Entities.DTOs.UserDataDTOs.UserRolesDTOs;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Text.Json;

namespace EHR_API.Controllers
{
    [Route("api/AuthenticationAPI")]
    [ApiController]
    public class AuthenticationAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMainRepository _db;
        private readonly IMapper _mapper;
        private readonly UserManager<RegistrationData> _userManager;

        public AuthenticationAPIController(IMainRepository db, IMapper mapper, UserManager<RegistrationData> userManager)
        {
            _db = db;
            _response = new();
            _mapper = mapper;
            _userManager = userManager;
        }

        [Authorize]
        [HttpGet("GetUsersRegistrationData")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<APIResponse>> GetUsersRegistrationData([FromQuery(Name = "searchUsername")] string userName = null, [FromQuery(Name = "filterByUserRole")] string role = null, int pageNumber = 1, int pageSize = 0, [FromHeader] string jwtToken = null)
        {
            try
            {
                IEnumerable<RegistrationData> entities = new List<RegistrationData>();
                string headerRole = null;
                if(jwtToken != null)
                {
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerRole = user.Claims.ToList()[1].Value;

                    if (headerRole == SD.Physician || headerRole == SD.Nurse || headerRole == SD.HealthFacilityManager || headerRole == SD.Pharmacist || headerRole == SD.Technician)
                    {
                       entities =  await _db._authentication.GetAllAsync(
                                includeProperties: "PersonalData,InsuranceData,MedicalData,MedicalTeam,Patient",
                                expression: userName == null ? null : g => g.UserName.ToLower().Contains(userName.ToLower()),
                                pageNumber: pageNumber,
                                pageSize: pageSize);
                    }
                    else
                    {
                        entities = await _db._authentication.GetAllAsync(
                                 includeProperties: "PersonalData,MedicalTeam,Patient",
                                 expression: userName == null ? null : g => g.UserName.ToLower().Contains(userName.ToLower()),
                                 pageNumber: pageNumber,
                                 pageSize: pageSize);
                    }

                    if (entities.ToList().Count == 0)
                    {
                        return NotFound(APIResponses.NotFound("No data has been found"));
                    }

                    Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };
                    Response.Headers.Add("Pagination", JsonSerializer.Serialize(pagination));

                    var newEntities = _mapper.Map<IEnumerable<RegistrationDataDTO>>(entities);
                    foreach (var item in newEntities)
                    {
                        item.Roles = await _userManager.GetRolesAsync(_mapper.Map<RegistrationData>(item));
                    }

                    if (role != null)
                    {
                        newEntities = newEntities.Where(e => e.Roles.Contains(role));
                    }

                    _response.Result = newEntities;
                    _response.StatusCode = HttpStatusCode.OK;
                    return Ok(_response);
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest("jwtToken is empty"));
                }
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize]
        [HttpGet("{id}", Name = "GetUserRegistrationData")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> GetUserRegistrationData(string id, [FromHeader] string jwtToken = null)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var entity = new RegistrationData();
                string headerRole = null;
                if (jwtToken != null)
                {
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerRole = user.Claims.ToList()[1].Value;

                    if (headerRole == SD.Physician || headerRole == SD.Nurse || headerRole == SD.HealthFacilityManager || headerRole == SD.Pharmacist || headerRole == SD.Technician)
                    {
                        entity = await _db._authentication.GetAsync(
                                 expression: g => g.Id == id,
                                 includeProperties: "PersonalData,InsuranceData,MedicalData,MedicalTeam,Patient");
                    }
                    else
                    {
                        entity = await _db._authentication.GetAsync(
                                 expression: g => g.Id == id,
                                 includeProperties: "PersonalData,MedicalTeam,Patient");
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest("jwtToken is empty"));
                }
 

                if (entity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                var newEntity = _mapper.Map<RegistrationDataDTO>(entity);
                newEntity.Roles = await _userManager.GetRolesAsync(_mapper.Map<RegistrationData>(entity));
                
                _response.Result = newEntity;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpGet("GetRoles")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetRoles([FromHeader] string jwtToken = null)
        {
            try
            {
                IEnumerable<IdentityRole> entities = await _db._role.GetRolesAsync(); 
                if (entities.ToList().Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                IdentityRole result = null;
                string headerRole = null;

                if (jwtToken != null)
                {
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerRole = user.Claims.ToList()[1].Value;
 
                    if (headerRole == SD.Physician || headerRole == SD.Nurse)
                    {
                        result = entities.Where(r => r.Name == SD.Patient).SingleOrDefault();
                    }

                    if (headerRole == SD.SystemManager)
                    {
                        result = entities.Where(r => r.Name == SD.HealthFacilitiesAdministrator).SingleOrDefault();
                    }

                    if (headerRole == SD.HealthFacilitiesAdministrator)
                    {
                        result = entities.Where(r => r.Name == SD.HealthFacilityManager).SingleOrDefault();
                    }

                    if (headerRole == SD.HealthFacilityManager)
                    {
                        entities = entities.Where(r => r.Name == SD.Physician || r.Name == SD.Nurse || r.Name == SD.Pharmacist);
                    }
                }

                if (headerRole == null)
                {
                    result = entities.Where(r => r.Name == SD.Patient).SingleOrDefault();
                }

                if (result != null)
                {
                    _response.Result = _mapper.Map<RolesDTO>(result);
                }
                else
                {
                    _response.Result = _mapper.Map<List<RolesDTO>>(entities);
                }

                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return BadRequest(APIResponses.InternalServerError(ex));
            }
        }

        [HttpPost("RegisterUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> RegisterUser([FromBody] RegistrationDataCreateDTO registrationDataDTO)
        {
            try
            {
                if (registrationDataDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

               var result = await _db._authentication.RegisterUser(registrationDataDTO);
                if (!result.Succeeded)
                {
                    return BadRequest(APIResponses.BadRequest(result.ToString()));
                }

                _response.Result = result;
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpPost("Login")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> Login([FromBody] LoginRequestDTO user) 
        {
            try
            {
                var _user = await _db._authentication.ValidateUser(user);
                if (_user == null)
                {
                    return APIResponses.Unauthorized();
                }

                var loginResponse = new LoginResponseDTO()
                {
                    User = _mapper.Map<LoginResponseaDataDTO>(_user),
                    Roles = await _userManager.GetRolesAsync(_user),
                    Token = await _db._authentication.CreateToken()
                };

                _response.Result = loginResponse;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[HttpPost("Logout")]
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[Authorize]
        //public async Task<ActionResult<APIResponse>> Logout([FromBody] LogoutRequestDTO user)
        //{
        //    try
        //    {
        //        var result = await _db._authentication.LogoutAsync(user);
        //        if (result)
        //        {
        //            _response.Result = result;
        //            _response.StatusCode = HttpStatusCode.OK;
        //            return Ok(_response);
        //        }

        //        return BadRequest(APIResponses.BadRequest("Logout failed"));
        //    }
        //    catch (Exception ex)
        //    {
        //        return APIResponses.InternalServerError(ex);
        //    }
        //}
        
        
        [Authorize]
        [HttpPut("{id}", Name = "UpdateRegistrationData")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateRegistrationData(string id, [FromBody] RegistrationDataUpdateDTO entityUpdateDTO)
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

                if (await _db._authentication.GetAsync(expression: g => g.Id == id) == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

               await _db._authentication.UpdateAsync(entityUpdateDTO);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<RegistrationDataDTO>(entityUpdateDTO);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }



    }
}
