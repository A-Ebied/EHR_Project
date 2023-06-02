using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.BloodDonationDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/BloodDonationAPI")]
    [ApiController]
    public class BloodDonationAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public BloodDonationAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }


        [Authorize]
        [HttpGet("GetUserBloodDonations")]     
        public async Task<ActionResult<APIResponse>> GetUserBloodDonations(string UserId)
        {
            try
            {
                if (UserId == null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var entities = await _db._bloodDonation.GetAllAsync(
                    expression: g => g.RegistrationDataId == UserId);

                if (entities.Count == 0)
                {
                    return BadRequest(APIResponses.BadRequest($"No objects with Id = {UserId} "));
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

                    if (headerId != UserId && headerRole != SD.Physician && headerRole != SD.HealthFacilityManager && headerRole != SD.SystemManager)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                _response.Result = _mapper.Map<List<BloodDonationDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<APIResponse>> GetBloodDonation(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id is less than 1"));
                }

                var entity = await _db._bloodDonation.GetAsync(
                    expression: g => g.Id == id);

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id} "));
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

                    if (headerId != entity.RegistrationDataId && headerRole != SD.Physician && headerRole != SD.HealthFacilityManager && headerRole != SD.SystemManager)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                _response.Result = _mapper.Map<BloodDonationDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        [HttpPost("CreateBloodDonation")]
        [Authorize(Roles = SD.HealthFacilityManager + "," + SD.Physician)]
        public async Task<ActionResult<APIResponse>> CreateBloodDonation([FromBody] BloodDonationCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._authentication.GetAsync(expression: e => e.Id == entityCreateDTO.RegistrationDataId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("User is not exists"));
                }
                
                if (await _db._medicalTeam.GetAsync(expression: e => e.Id == entityCreateDTO.MedicalTeamId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Medical member is not exists"));
                }

                var entity = _mapper.Map<BloodDonation>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                await _db._bloodDonation.CreateAsync(entity);

                _response.Result = _mapper.Map<BloodDonationDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        [HttpDelete("{id}")]
        [Authorize(Roles = SD.HealthFacilityManager + "," + SD.Physician)]
        public async Task<ActionResult<APIResponse>> DeleteBloodDonation(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var removedEntity = await _db._bloodDonation.GetAsync(
                        expression: g => g.Id == id);

                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                await _db._bloodDonation.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = "The object has been deleted";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize]

        [HttpPut("{id}")]
        [Authorize(Roles = SD.HealthFacilityManager + "," + SD.Physician)]
        public async Task<ActionResult<APIResponse>> UpdateBloodDonation(int id, [FromBody] BloodDonationUpdateDTO entityUpdateDTO)
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

                var oldOne = await _db._bloodDonation.GetAsync(expression: g => g.Id == id);
                if (oldOne == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                string jwtToken = null;
                if (HttpContext.Request.Headers.Authorization.Count > 0)
                {
                    jwtToken = HttpContext.Request.Headers.Authorization.ToString().Split(" ")[1];
                }

                string headerId = null;

                if (jwtToken != null)
                {
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerId = user.Claims.ToList()[0].Value;

                    if (headerId != oldOne.MedicalTeamId)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }
                 
                if (await _db._authentication.GetAsync(expression: e => e.Id == entityUpdateDTO.RegistrationDataId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("User is not exists"));
                }
                
                if (await _db._medicalTeam.GetAsync(expression: e => e.Id == entityUpdateDTO.MedicalTeamId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Medical member is not exists"));
                }

                var entity = _mapper.Map<BloodDonation>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                entity.CreatedAt = oldOne.CreatedAt;
                await _db._bloodDonation.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<BloodDonationDTO> (entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
    }
}
