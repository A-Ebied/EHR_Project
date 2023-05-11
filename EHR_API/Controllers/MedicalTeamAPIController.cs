using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.UserDataDTOs.MedicalTeamDTOs;
using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> GetMedicalMember(string userId)
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

                var entity = await _db._medicalTeam.GetAsync(
                    expression: g => g.Id == userId,
                    includeProperties: "MedicalFacilityTeams");

                if (entity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with User Id = {userId} "));
                }

                _response.Result = _mapper.Map<MedicalTeamDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.HealthFacilityManager)]
        //[Authorize]
        [HttpPost("CreateMedicalTeamUser")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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

                var entity = _mapper.Map<MedicalTeam>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                entity.MedicalFacilityTeams = null;

                await _db._medicalTeam.CreateAsync(entity);

                if (entityCreateDTO.MedicalFacilityTeams.Count > 0)
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

        //[Authorize(Roles = SD.HealthFacilityManager)]
        //[Authorize]
        [HttpDelete("{userId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteMedicalTeamUser(string userId)
        {
            try
            {
                if (userId == null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var removedEntity = await _db._medicalTeam.GetAsync(expression: g => g.Id == userId);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {userId} "));
                }

                await _db._medicalTeam.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = "The object has been deleted";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.HealthFacilityManager)]
        //[Authorize]
        [HttpPut("{userId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
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

                if (await _db._medicalTeam.GetAsync(expression: g => g.Id == userId) == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {userId} "));
                }

                var entity = _mapper.Map<MedicalTeam>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
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
