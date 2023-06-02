using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.MedicalFacilityTeamDTOs;
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
    [Route("api/MedicalFacilityTeamAPI")]
    [ApiController]
    public class MedicalFacilityTeamAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public MedicalFacilityTeamAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }

        [HttpPost("CreateMedicalFacilityTeam")]
        [Authorize(Roles = SD.HealthFacilityManager + "," + SD.SystemManager)]
        public async Task<ActionResult<APIResponse>> CreateMedicalFacilityTeam([FromBody] MedicalFacilityTeamCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._healthFacility.GetAsync(expression: e => e.Id == entityCreateDTO.HealthFacilityId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Health Facility is not exists"));
                }
                
                if (await _db._medicalTeam.GetAsync(expression: e => e.Id == entityCreateDTO.MedicalTeamId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Medical member is not exists"));
                }
             
                var entity = _mapper.Map<MedicalFacilityTeam>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;

                var managerId = _db._healthFacility.GetAsync(h=>h.Id == entityCreateDTO.HealthFacilityId).Result.MedicalTeamId;

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

                    if (headerId != managerId && headerRole == SD.HealthFacilityManager)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                await _db._facilityTeam.CreateAsync(entity);
                 
                _response.Result = _mapper.Map<MedicalFacilityTeamDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        [HttpDelete("{id}")]
        [Authorize(Roles = SD.HealthFacilityManager + "," + SD.SystemManager)]
        public async Task<ActionResult<APIResponse>> DeleteMedicalFacilityTeam(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var removedEntity = await _db._facilityTeam.GetAsync(expression: g => g.Id == id);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                var managerId = _db._healthFacility.GetAsync(h => h.Id == removedEntity.HealthFacilityId).Result.MedicalTeamId;

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

                    if (headerId != managerId && headerRole == SD.HealthFacilityManager)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                await _db._facilityTeam.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = "The object has been deleted";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
    }
}
