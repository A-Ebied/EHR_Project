using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.UserDataDTOs;
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

        //[Authorize(Roles = SD.SystemManager)]
        [HttpGet("GetSystemManagers")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<APIResponse>> GetSystemManagers([FromQuery(Name = "UserName")] string userName = null, int pageNumber = 1, int pageSize = 0)
        {
            try
            {
                IEnumerable<RegistrationData> entities = new List<RegistrationData>();
                entities = await _db._authentication.GetAllAsync(
                    expression: userName == null ? null : e => e.UserName.ToLower().Contains(userName),
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

                if (pageSize > 0)
                {
                    systemManagers = (systemManagers.Skip(pageSize * (pageNumber - 1)).Take(pageSize)).ToList();
                }

                List<UserDTOForOthers> managerUsers = new();
                foreach (var item in systemManagers)
                {
                    managerUsers.Add(APIResponses.User(_mapper.Map<RegistrationData>(item)));
                }

                Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };
                Response.Headers.Add("Pagination", JsonSerializer.Serialize(pagination));

                _response.Result = managerUsers;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);

            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.SystemManager)]
        [HttpGet("GetHealthFacilitiesAdministrators")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<APIResponse>> GetHealthFacilitiesAdministrators([FromQuery(Name = "UserName")] string userName = null, int pageNumber = 1, int pageSize = 0)
        {
            try
            {
                IEnumerable<RegistrationData> entities = new List<RegistrationData>();
                entities = await _db._authentication.GetAllAsync(
                    expression: userName == null ? null : e => e.UserName.ToLower().Contains(userName),
                    includeProperties: "PersonalData");

                var hFAdministrators = new List<RegistrationData>();
                IEnumerable<string> roles = new List<string>();
                foreach (var entity in entities)
                {
                    roles = await _userManager.GetRolesAsync(entity);
                    if (roles.Contains("HealthFacilitiesAdministrator") == true)
                    {
                        hFAdministrators.Add(entity);
                    }
                }

                if (hFAdministrators.ToList().Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                if (pageSize > 0)
                {
                    hFAdministrators = (hFAdministrators.Skip(pageSize * (pageNumber - 1)).Take(pageSize)).ToList();
                }

                List<UserDTOForOthers> administrators = new();
                foreach (var item in hFAdministrators)
                {
                    administrators.Add(APIResponses.User(_mapper.Map<RegistrationData>(item)));
                }

                Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };
                Response.Headers.Add("Pagination", JsonSerializer.Serialize(pagination));

                _response.Result = administrators;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);

            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.HealthFacilitiesAdministrator)]
        [HttpGet("GetHealthFacilityManagers")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<APIResponse>> GetHealthFacilityManagers([FromQuery(Name = "Nationality")] string nationality = null, int pageNumber = 1, int pageSize = 0)
        {
            try
            {
                IEnumerable<RegistrationData> entities = new List<RegistrationData>();
                entities = await _db._authentication.GetAllAsync(
                    expression: nationality == null ? null : e => e.Nationality.ToLower().Contains(nationality),
                    includeProperties: "PersonalData,MedicalTeam");

                var managers = new List<RegistrationData>();
                IEnumerable<string> roles = new List<string>();
                foreach (var entity in entities)
                {
                    roles = await _userManager.GetRolesAsync(entity);
                    if (roles.Contains("HealthFacilityManager") == true ) 
                    {
                        managers.Add(entity);
                    }
                }
                 
                if (managers.ToList().Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                if (pageSize > 0)
                {
                    managers = (managers.Skip(pageSize * (pageNumber - 1)).Take(pageSize)).ToList();
                }

                List<UserDTOForOthers> managerUsers = new();
                foreach (var item in managers)
                {
                    managerUsers.Add(APIResponses.User(_mapper.Map<RegistrationData>(item)));
                }

                Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };
                Response.Headers.Add("Pagination", JsonSerializer.Serialize(pagination));

                _response.Result = managerUsers;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);

            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.HealthFacilitiesAdministrator + "," + SD.HealthFacilityManager)]
        [HttpGet("GetMedicalUsers")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<APIResponse>> GetMedicalUsers([FromQuery(Name = "filterByMedicalSpecialization")] string medicalSpecialization = null, int pageNumber = 1, int pageSize = 0)
        {
            try
            {
                IEnumerable<MedicalTeam> medicalTeam = new List<MedicalTeam>();
                var entities = new List<RegistrationData>();

                medicalTeam = await _db._medicalTeam.GetAllAsync(
                    expression: medicalSpecialization == null ? null : m => m.MedicalSpecialization.Contains(medicalSpecialization),
                    pageNumber: pageNumber,
                    pageSize: pageSize);

                if (medicalTeam.ToList().Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                foreach (var entity in medicalTeam)
                {
                    entities.Add(await _db._authentication.GetAsync(
                        includeProperties: "PersonalData,MedicalTeam",
                        expression: e => e.Id == entity.Id));
                }
                 
                Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };
                Response.Headers.Add("Pagination", JsonSerializer.Serialize(pagination));

                List<UserDTOForOthers> medicalUsers = new();
                foreach (var item in entities)
                {
                    medicalUsers.Add(APIResponses.User(_mapper.Map<RegistrationData>(item)));
                }

                _response.Result = medicalUsers;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);

            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.HealthFacilitiesAdministrator + "," + SD.HealthFacilityManager)]
        //[HttpGet("GetPatientUsers")]
        //[ResponseCache(CacheProfileName = SD.ProfileName)]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        //public async Task<ActionResult<APIResponse>> GetPatientUsers([FromQuery(Name = "AgeGroup")] string ageGroup = null, int pageNumber = 1, int pageSize = 0)
        //{
        //    try
        //    {
        //        IEnumerable<Patient> patients = new List<Patient>();
        //        var entities = new List<RegistrationData>();

        //        patients = await _db._patient.GetAllAsync(
        //            expression: ageGroup == null ? null : m => m.AgeGroup.Contains(ageGroup),
        //            pageNumber: pageNumber,
        //            pageSize: pageSize);

        //        if (patients.ToList().Count == 0)
        //        {
        //            return NotFound(APIResponses.NotFound("No data has been found"));
        //        }

        //        foreach (var entity in patients)
        //        {
        //            entities.Add(await _db._authentication.GetAsync(
        //                includeProperties: "PersonalData",
        //                expression: e => e.Id == entity.Id));
        //        }

        //        Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };
        //        Response.Headers.Add("Pagination", JsonSerializer.Serialize(pagination));

        //        List<UserDTOForOthers> patientsUsers = new();
        //        foreach (var item in entities)
        //        {
        //            patientsUsers.Add(APIResponses.User(_mapper.Map<RegistrationData>(item)));
        //        }

        //        _response.Result = patientsUsers;
        //        _response.StatusCode = HttpStatusCode.OK;
        //        return Ok(_response);

        //    }
        //    catch (Exception ex)
        //    {
        //        return APIResponses.InternalServerError(ex);
        //    }
        //}

        /*
        [Authorize(Roles = SD.SystemManager)]
        [HttpGet("GetAllUsersData")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<APIResponse>> GetAllUsersData([FromQuery(Name = "filterByUserRole")] string role = null, int pageNumber = 1, int pageSize = 0)
        {
            try
            {
                IEnumerable<RegistrationData> entities = new List<RegistrationData>();
                entities = await _db._authentication.GetAllAsync(
                        includeProperties: "PersonalData,InsuranceData,MedicalData,MedicalTeam,Patient",
                        pageNumber: pageNumber,
                        pageSize: pageSize);

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
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
        */


        //[Authorize]
        
        [HttpGet("{id}")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> GetUser(string id)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                string jwtToken = null;
                if (HttpContext.Request.Headers.Authorization.Count > 0)
                {
                    jwtToken = HttpContext.Request.Headers.Authorization.ToString().Split(" ")[1];
                }

                var entity = new RegistrationData();
                string headerRole = null;
                string headerId = null;
                if (jwtToken != null)
                {
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerRole = user.Claims.ToList()[4].Value;
                    headerId = user.Claims.ToList()[0].Value;

                    if (headerRole == SD.Physician || headerRole == SD.Nurse || headerRole == SD.HealthFacilityManager || headerRole == SD.Pharmacist || headerRole == SD.Technician || headerId == id)
                    {
                        entity = await _db._authentication.GetAsync(
                                 expression: g => g.Id == id,
                                 includeProperties: "PersonalData,MedicalData,MedicalTeam");
                    }
                    
                }
                else
                {
                    entity = await _db._authentication.GetAsync(
                             expression: g => g.Id == id,
                             includeProperties: "PersonalData,MedicalTeam");
                }
                //else
                //{
                //    return BadRequest(APIResponses.BadRequest("jwtToken is empty"));
                //}

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

                IEnumerable<IdentityRole> result = null;
                string headerRole = null;

                if (jwtToken != null)
                {
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerRole = user.Claims.ToList()[1].Value;

                    if (headerRole == SD.Physician || headerRole == SD.Nurse)
                    {
                        result = entities.Where(r => r.Name == SD.Patient);
                    }

                    if (headerRole == SD.SystemManager)
                    {
                        result = entities.Where(r => r.Name == SD.HealthFacilitiesAdministrator);
                    }

                    if (headerRole == SD.HealthFacilitiesAdministrator)
                    {
                        result = entities.Where(r => r.Name == SD.HealthFacilityManager);
                    }

                    if (headerRole == SD.HealthFacilityManager)
                    {
                        entities = entities.Where(r => r.Name == SD.Physician || r.Name == SD.Nurse || r.Name == SD.Pharmacist);
                    }
                }

                if (headerRole == null)
                {
                    result = entities.Where(r => r.Name == SD.Patient);
                }

                if (result != null)
                {
                    _response.Result = _mapper.Map<List<RolesDTO>>(result);
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

     
        [Authorize]
        [HttpPut("{id}")]
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
