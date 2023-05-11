using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.UserDataDTOs.PersonalDataDTOs;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EHR_API.Controllers
{
    //[Authorize]
    [Route("api/PersonalDataAPI")]
    [ApiController]
    public class PersonalDataAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public PersonalDataAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }

        [HttpGet("{userId}")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> GetUserPersonalData(string userId)
        {
            try
            {
                if (userId == null)
                {
                    return BadRequest(APIResponses.BadRequest("User Id is null"));
                }

                /*
                string jwtToken = null;
                //if (HttpContext.Request.Headers.Authorization.Count > 0)
                //{
                //    jwtToken = HttpContext.Request.Headers.Authorization.ToString().Split(" ")[1];
                //}
                //var entity = new RegistrationData();
                //string headerRole = null;
                //string headerId = null;
                //if (jwtToken != null)
                //{
                //    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                //    headerRole = user.Claims.ToList()[4].Value;
                //    headerId = user.Claims.ToList()[0].Value;

                //    if (headerRole == SD.Physician || headerRole == SD.Nurse || headerRole == SD.HealthFacilityManager || headerRole == SD.Pharmacist || headerRole == SD.Technician || headerId == userId)
                //    {
                //        entity = await _db._authentication.GetAsync(
                //                 expression: g => g.Id == userId,
                //                 includeProperties: "PersonalData,MedicalData,MedicalTeam");
                //    }

                //}
                //else
                //{
                //    entity = await _db._authentication.GetAsync(
                //             expression: g => g.Id == userId,
                //             includeProperties: "PersonalData,MedicalTeam");
                }
                */

                var entity = await _db._personal.GetAsync(expression: g => g.Id == userId);

                if (entity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with User Id = {userId} "));
                }

                _response.Result = _mapper.Map<PersonalDataDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpPost("CreateUserPersonalData")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateUserPersonalData([FromForm] PersonalDataCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._governorate.GetAsync(expression: e => e.Id == entityCreateDTO.GovernorateId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Governorate is not exists"));
                }

                if (await _db._personal.GetAsync(expression: g => g.Id.ToLower() == entityCreateDTO.Id.ToLower()) != null)
                {
                    return BadRequest(APIResponses.BadRequest("The object is already exists"));
                }

                var entity = _mapper.Map<PersonalData>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                await _db._personal.CreateAsync(entity);

                _response.Result = _mapper.Map<PersonalDataDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpDelete("{userId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeletePersonalData(string userId)
        {
            try
            {
                if (userId == null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var removedEntity = await _db._personal.GetAsync(expression: g => g.Id == userId);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {userId} "));
                }

                await _db._personal.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = "The object has been deleted";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        [HttpPut("{userId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateUserPersonalData(string userId, [FromForm] PersonalDataUpdateDTO entityUpdateDTO)
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

                var oldEntity = await _db._personal.GetAsync(expression: g => g.Id == userId);
                if (oldEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {userId} "));
                }

                var entity = _mapper.Map<PersonalData>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                await _db._personal.UpdateAsync(entity, oldEntity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<PersonalDataDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
    }
}
