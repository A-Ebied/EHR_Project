using AutoMapper;
using Azure;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.GovernorateDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs;
using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/AuthenticationAPI")]
    [ApiController]
    public class AuthenticationAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IAuthenticationRepository _db;
        private readonly IMapper _mapper;
        private readonly UserManager<RegistrationData> _userManager;

        public AuthenticationAPIController(IAuthenticationRepository db, IMapper mapper, UserManager<RegistrationData> userManager)
        {
            _db = db;
            _response = new();
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpPost("RegisterUser")]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> RegisterUser([FromBody] RegistrationDataDTO registrationDataDTO)
        {
            try
            {
                if (registrationDataDTO == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    return BadRequest(_response);
                }


               var result = await _db.RegisterUser(registrationDataDTO);
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

        [HttpPost("login")]
        public async Task<ActionResult<APIResponse>> Authenticate([FromBody] LoginRequestDTO user) 
        {
            var _user = await _db.ValidateUser(user);
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
                Token = await _db.CreateToken()
            };

            _response.Result = loginResponse;
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);
        }

    }
}
