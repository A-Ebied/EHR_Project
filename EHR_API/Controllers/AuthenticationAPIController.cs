using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.HealthFacilityDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Login;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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

        [HttpPost("RegisterUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> RegisterUser([FromBody] RegistrationDataCreateDTO registrationDataDTO)
        {
            try
            {
                if (registrationDataDTO == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    return BadRequest(_response);
                }


               var result = await _db._authentication.RegisterUser(registrationDataDTO);
                if (!result.Succeeded)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.Errors = new List<string> { result.ToString() };

                    return BadRequest(_response);
                }

                _response.Result = result;
                _response.StatusCode = HttpStatusCode.Created;

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Errors = new List<string> { ex.ToString() };
                return _response;
            }


        }

        [HttpPost("Login")]
        public async Task<ActionResult<APIResponse>> Login([FromBody] LoginRequestDTO user) 
        {
            var _user = await _db._authentication.ValidateUser(user);
            if ( _user == null)
            {
                _response.Errors = new() { "The Email and Password are wrong" };
                _response.IsSuccess=false;
                _response.StatusCode=HttpStatusCode.Unauthorized;
                return Unauthorized(_response);
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

        [HttpGet("GetUsersRegistrationData")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        //[Authorize]
        //[Authorize(Roles = SD.SystemManager)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetUsersRegistrationData([FromQuery(Name = "searchUsername")] string userName = null, int pageNumber = 1, int pageSize = 0)
        {
            try
            {
                var entities = await _db._authentication.GetAllAsync(
                    includeProperties: "HealthFacility",
                    exception: userName == null ? null : g => g.UserName.ToLower().Contains(userName.ToLower()),
                    pageNumber: pageNumber,
                    pageSize: pageSize
                    );

                if (entities.Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };
                Response.Headers.Add("Pagination", JsonSerializer.Serialize(pagination));

                _response.Result = _mapper.Map<List<RegistrationDataDTO>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpGet("{id}", Name = "GetUserRegistrationData")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetUserRegistrationData(string id)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var entity = await _db._authentication.GetAsync(exception: g => g.Id == id, includeProperties: "HealthFacility");
                if (entity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                _response.Result = _mapper.Map<RegistrationDataDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

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

                if (await _db._authentication.GetAsync(exception: g => g.Id == id) == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                var entity = _mapper.Map<RegistrationData>(entityUpdateDTO);
                await _db._authentication.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<RegistrationDataDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
    }
}
