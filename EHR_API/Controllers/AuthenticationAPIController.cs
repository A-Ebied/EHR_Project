using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.UserDataDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Login;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_API.Entities.DTOs.UserDataDTOs.RolesDTOs;
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

        [HttpGet("GetSystemManagers")]
        [Authorize(Roles = SD.SystemManager)]
        public async Task<ActionResult<APIResponse>> GetSystemManagers()
        {
            try
            {
                IEnumerable<RegistrationData> entities = new List<RegistrationData>();
                entities = await _db._authentication.GetAllAsync(
                    includeProperties: "PersonalData");

                var systemManagers = new List<RegistrationData>();
                IEnumerable<string> roles = new List<string>();
                foreach (var entity in entities)
                {
                    roles = await _userManager.GetRolesAsync(entity);
                    if (roles.Contains("SystemManager") == true)
                    {
                        systemManagers.Add(entity);
                    }
                }

                if (systemManagers.ToList().Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                List<UserDTOForOthers> managerUsers = new();
                foreach (var item in systemManagers)
                {
                    managerUsers.Add(APIResponses.User(_mapper.Map<RegistrationData>(item), "SystemManager"));
                }

                _response.Result = managerUsers;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);

            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        [HttpGet("GetHealthFacilityManagers")]
        [Authorize(Roles = SD.SystemManager)]
        public async Task<ActionResult<APIResponse>> GetHealthFacilityManagers()
        {
            try
            {
                IEnumerable<MedicalTeam> entities = new List<MedicalTeam>();
                entities = await _db._medicalTeam.GetAllAsync(
                   includeProperties: "RegistrationData");

                var managers = new List<RegistrationData>();
                IEnumerable<string> roles = new List<string>();
                foreach (var entity in entities)
                {
                    roles = await _userManager.GetRolesAsync(entity.RegistrationData);
                    if (roles.Contains("HealthFacilityManager") == true)
                    {
                        managers.Add(entity.RegistrationData);
                    }
                }

                if (managers.ToList().Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                List<UserDTOForOthers> managerUsers = new();
                foreach (var item in managers)
                {
                    managerUsers.Add(APIResponses.User(_mapper.Map<RegistrationData>(item), "HealthFacilityManager"));
                }

                _response.Result = managerUsers;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);

            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        [HttpGet("GetMedicalUsers")]
        public async Task<ActionResult<APIResponse>> GetMedicalUsers()
        {
            try
            {
                IEnumerable<RegistrationData> entities = new List<RegistrationData>();
                entities = await _db._authentication.GetAllAsync(
                    includeProperties: "PersonalData,MedicalTeam");

                var medicalUsers = new List<RegistrationData>();
                IEnumerable<string> roles = new List<string>();
                foreach (var entity in entities)
                {
                    roles = await _userManager.GetRolesAsync(entity);
                    if (roles.Contains("Physician") == true || roles.Contains("Nurse") == true || roles.Contains("Technician") == true || roles.Contains("Pharmacist") == true)
                    {
                        medicalUsers.Add(entity);
                    }
                }

                if (medicalUsers.ToList().Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                if (medicalUsers.ToList().Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                List<UserDTOForOthers> medicalTeam = new();
                var role = "";
                foreach (var item in medicalUsers)
                {
                    role = _userManager.GetRolesAsync(item).Result.FirstOrDefault();
                    medicalTeam.Add(APIResponses.User(_mapper.Map<RegistrationData>(item), role));
                }

                _response.Result = medicalTeam;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);

            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpGet("{userId}")]
        public async Task<ActionResult<APIResponse>> GetUser(string userId)
        {
            try
            {
                if (userId == null)
                {
                    return BadRequest(APIResponses.BadRequest("User Id is null"));
                }

                var entity = new RegistrationData();

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

                    if (headerRole == SD.Physician || headerRole == SD.HealthFacilityManager|| headerRole == SD.SystemManager || headerRole == SD.Pharmacist || headerRole == SD.Technician || headerId == userId)
                    {
                        entity = await _db._authentication.GetAsync(
                            expression: g => g.Id == userId,
                            includeProperties: "PersonalData,MedicalTeam,MedicalData,UserInsurances,BadHabits,Contraindications,Allergies,Visits,Admits,BloodDonations,ChronicDiseases");
                    }
                }
                else
                {
                    entity = await _db._authentication.GetAsync(
                             expression: g => g.Id == userId,
                             includeProperties: "PersonalData,MedicalTeam");
                }

                if (entity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {userId} "));
                }

                if (entity.MedicalTeam != null)
                {
                    entity.MedicalTeam.MedicalFacilityTeams = await _db._facilityTeam.GetAllAsync(
                        expression: t => t.MedicalTeamId == userId);
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

        [Authorize]
        [HttpGet("GetUsers")]
        public async Task<ActionResult<APIResponse>> GetUsers()
        {
            try
            {
                var entities = await _db._authentication.GetAllAsync(
                            includeProperties: "PersonalData,MedicalTeam");

                if (entities == null || entities.Count == 0)
                {
                    return NotFound(APIResponses.NotFound($"No objects"));
                }

                List<UserDTOForOthers> users = new();
                var role = "";
                foreach (var item in entities)
                {
                    role = _userManager.GetRolesAsync(item).Result.FirstOrDefault();
                    users.Add(APIResponses.User(_mapper.Map<RegistrationData>(item), role));
                }

                _response.Result = users;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpGet("GetRoles")]
        public async Task<ActionResult<APIResponse>> GetRoles()
        {
            try
            {
                IEnumerable<IdentityRole> entities = await _db._role.GetRolesAsync();
                if (entities.ToList().Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                string jwtToken = null;
                if (HttpContext.Request.Headers.Authorization.Count > 0)
                {
                    jwtToken = HttpContext.Request.Headers.Authorization.ToString().Split(" ")[1];
                }

                IEnumerable<IdentityRole> result = null;
                string headerRole = null;

                if (jwtToken != null)
                {
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerRole = user.Claims.ToList()[4].Value;

                    if (headerRole == SD.Physician)
                    {
                        result = entities.Where(r => r.Name == SD.Patient);
                    }

                    if (headerRole == SD.SystemManager)
                    {
                        result = entities.Where(r => r.Name == SD.SystemManager || r.Name == SD.HealthFacilityManager);
                    }

                    if (headerRole == SD.HealthFacilityManager)
                    {
                        result = entities.Where(r => r.Name == SD.Physician || r.Name == SD.Technician || r.Name == SD.Pharmacist);
                    }
                }

                if (headerRole == null)
                {
                    result = entities.Where(r => r.Name == SD.Patient);
                }

                //if (result != null)
                //{
                //    _response.Result = _mapper.Map<List<RolesDTO>>(result);
                //}
                //else
                //{
                //    _response.Result = _mapper.Map<List<RolesDTO>>(entities);
                //}

                _response.Result = _mapper.Map<List<RolesDTO>>(result);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return BadRequest(APIResponses.InternalServerError(ex));
            }
        }

        [HttpPost("RegisterUser")]
        public async Task<ActionResult<APIResponse>> RegisterUser([FromBody] RegistrationDataCreateDTO registrationDataDTO)
        {
            try
            {
                if (registrationDataDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._authentication.GetAsync(expression: r => r.Id == registrationDataDTO.Id) != null)
                {
                    return BadRequest(APIResponses.BadRequest("Enter another Id"));
                }

                var x = true;
                string jwtToken = null;
                if (HttpContext.Request.Headers.Authorization.Count > 0)
                {
                    jwtToken = HttpContext.Request.Headers.Authorization.ToString().Split(" ")[1];

                    string headerRole = null;
                    if (jwtToken != null)
                    {
                        var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                        headerRole = user.Claims.ToList()[4].Value;

                        if (headerRole == SD.HealthFacilityManager || headerRole == SD.SystemManager)
                        {
                           x = false;
                        }
                        else
                        {
                            return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                        }
                    }
                }
                 
                var result = await _db._authentication.RegisterUser(registrationDataDTO, x);
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

        [HttpPut("ConfirmEmail")]
        public async Task<ActionResult<APIResponse>> ConfirmEmail(string email, string code)
        {
            try
            {
                if (email == null || code == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                var user = await _db._authentication.ConfirmEmail(email, code);
                if (user != null)
                {
                    var loginResponse = new LoginResponseDTO()
                    {
                        User = _mapper.Map<LoginResponseaDataDTO>(user),
                        Roles = await _userManager.GetRolesAsync(user),
                        Token = await _db._authentication.CreateToken()
                    };

                    _response.Result = loginResponse;
                    _response.StatusCode = HttpStatusCode.OK;
                    return Ok(_response);
                }
                else
                {
                    _response.Result = "Oops! The verification code you entered is incorrect. Please try again. Thank you!";
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpPost("ReSendEmailConfirmCode")]
        public async Task<ActionResult<APIResponse>> ReSendEmailConfirmCode(string email)
        {
            try
            {
                if (email == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                await _db._authentication.ReSendEmailConfirmCode(email);

                _response.Result = "The code has been resent.";
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);

            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpPost("Login")]
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


        [HttpPost("ForgotPassword")]
        public async Task<ActionResult<APIResponse>> ForgotPassword(string email)
        {
            try
            {
                if (email == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                var result = await _db._authentication.ForgotPassword(email);

                if (result)
                {
                    _response.Result = "The code has been sent, you must register first.";
                    _response.StatusCode = HttpStatusCode.OK;
                    return Ok(_response);
                }
                else
                {
                    _response.Result = "The code has not been sent";
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpPut("NewPassword")]
        public async Task<ActionResult<APIResponse>> NewPassword(string email, string code, string password, string confirmPassword)
        {
            try
            {
                if (email == null || code == null || password == null || confirmPassword == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (password != confirmPassword)
                {
                    return BadRequest(APIResponses.BadRequest("Password & Confirm Password do not match"));
                }

                var user = await _db._authentication.NewPassword(email, code, password);
                if (user != null)
                {
                    var loginResponse = new LoginResponseDTO()
                    {
                        User = _mapper.Map<LoginResponseaDataDTO>(user),
                        Roles = await _userManager.GetRolesAsync(user),
                        Token = await _db._authentication.CreateToken()
                    };

                    _response.Result = loginResponse;
                    _response.StatusCode = HttpStatusCode.OK;
                    return Ok(_response);
                }
                else
                {
                    _response.Result = "Password has not been changed";
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize]
        [HttpPut("{userId}")]
        public async Task<ActionResult<APIResponse>> UpdateRegistrationData(string userId, [FromBody] RegistrationDataUpdateDTO entityUpdateDTO)
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

                var oldOne = await _db._authentication.GetAsync(expression: g => g.Id == userId);
                if ( oldOne == null)
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
                if (jwtToken != null)
                {
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerRole = user.Claims.ToList()[4].Value;
                    headerId = user.Claims.ToList()[0].Value;

                    if (headerRole == SD.Physician || headerRole == SD.HealthFacilityManager || headerId == userId)
                    {
                        await _db._authentication.UpdateAsync(entityUpdateDTO);
                    }
                    else
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                
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
