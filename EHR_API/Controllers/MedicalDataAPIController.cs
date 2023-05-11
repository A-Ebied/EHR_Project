using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.UserDataDTOs.MedicalDataDTOs;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/MedicalDataAPI")]
    [ApiController]
    public class MedicalDataAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public MedicalDataAPIController(IMainRepository db, IMapper mapper)
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
        public async Task<ActionResult<APIResponse>> GetUserMedicalData(string userId)
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

                var entity = await _db._medicalData.GetAsync(expression: g => g.Id == userId);

                if (entity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with User Id = {userId} "));
                }

                _response.Result = _mapper.Map<MedicalDataDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.Physician + SD.Nurse + "," + SD.Technician + "," + SD.HealthFacilityManager)]
        //[Authorize]
        [HttpPost("CreateUserMedicalData")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateUserMedicalData([FromForm] MedicalDataCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._medicalData.GetAsync(expression: g => g.Id.ToLower() == entityCreateDTO.Id.ToLower()) != null)
                {
                    return BadRequest(APIResponses.BadRequest("The object is already exists"));
                }

                var entity = _mapper.Map<MedicalData>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                await _db._medicalData.CreateAsync(entity);

                _response.Result = _mapper.Map<MedicalDataDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.Physician + "," + SD.Nurse + "," + SD.Technician + "," + SD.HealthFacilityManager)]
        //[Authorize]
        [HttpDelete("{userId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteUserMedicalData(string userId)
        {
            try
            {
                if (userId == null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var removedEntity = await _db._medicalData.GetAsync(expression: g => g.Id == userId);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {userId} "));
                }

                await _db._medicalData.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = "The object has been deleted";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.Pharmacist + "," + SD.Nurse + "," + SD.Technician + "," + SD.HealthFacilityManager)]
        //[Authorize]
        [HttpPut("{userId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateUserMedicalData(string userId, [FromForm] MedicalDataUpdateDTO entityUpdateDTO)
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

                var oldOne = await _db._medicalData.GetAsync(expression: g => g.Id == userId);
                if (oldOne == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {userId} "));
                }

                var entity = _mapper.Map<MedicalData>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                await _db._medicalData.UpdateAsync(entity, oldOne);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<MedicalDataDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
    }
}
