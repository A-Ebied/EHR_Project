using AutoMapper;
using Azure;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.GovernorateDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs;
using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Repositories.Contracts;
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
        public AuthenticationAPIController(IAuthenticationRepository db)
        {
            _db= db;
            _response= new();
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
        public async Task<IActionResult> Authenticate([FromBody] LoginRequestDTO user) 
        {
            if (!await _db.ValidateUser(user))
            {
                return Unauthorized("The Email and Password are wrong");
            }
            
            return Ok(new { Token = await _db.CreateToken() }); 
        }
    }
}
