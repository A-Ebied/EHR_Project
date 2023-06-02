using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.ChronicDiseaseDrugDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Net;


namespace EHR_API.Controllers
{
    [Route("api/ChronicDiseaseDrugAPI")]
    [ApiController]
    public class ChronicDiseaseDrugAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public ChronicDiseaseDrugAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }


        [Authorize]
        [HttpGet("GetChronicDiseaseDrugs")]
        public async Task<ActionResult<APIResponse>> GetChronicDiseaseDrugs(int chronicDiseaseId)
        {
            try
            {
                if (chronicDiseaseId < 1 )
                {
                    return BadRequest(APIResponses.BadRequest("Ids is < 1 "));
                }

                var entities = await _db._chronicDiseaseDrug.GetAllAsync(
                    includeProperties: "Medication,ChronicDisease",
                    expression: g => g.ChronicDiseaseId == chronicDiseaseId);

                if (entities.Count == 0)
                {
                    return BadRequest(APIResponses.BadRequest($"No objects with Id = {chronicDiseaseId}"));
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

                    if (headerId != entities[0].ChronicDisease.MedicalTeamId && headerRole != SD.Physician && headerRole != SD.HealthFacilityManager && headerRole != SD.SystemManager)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                _response.Result = _mapper.Map<List<ChronicDiseaseDrugDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        [HttpPost("CreateChronicDiseaseDrugs")]
        [Authorize(Roles = SD.HealthFacilityManager + "," + SD.Physician)]
        public async Task<ActionResult<APIResponse>> CreateChronicDiseaseDrugs([FromBody] ChronicDiseaseDrugsCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                foreach (var item in entityCreateDTO.ChronicDiseaseDrugs)
                {                    
                    if (await _db._medication.GetAsync(expression: e => e.Id == item.MedicationId) == null)
                    {
                        return BadRequest(APIResponses.BadRequest($"Medication with id {item.MedicationId} is not exists"));
                    }

                    if (await _db._chronicDisease.GetAsync(expression: e => e.Id == item.ChronicDiseaseId) == null)
                    {
                        return BadRequest(APIResponses.BadRequest($"Chronic Disease with id {item.ChronicDiseaseId} is not exists"));
                    }
                }

                var entities = _mapper.Map<List<ChronicDiseaseDrug>>(entityCreateDTO.ChronicDiseaseDrugs);
                foreach (var item in entities)
                {
                    item.CreatedAt = DateTime.Now;
                    item.UpdatedAt = DateTime.Now;
                }
                await _db._chronicDiseaseDrug.CreateRangeAsync(entities);

                _response.Result = _mapper.Map<List<ChronicDiseaseDrugDTO>>(entities);
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
        public async Task<ActionResult<APIResponse>> DeleteChronicDiseaseDrug(int id)
        {
            try
            {
                if (id < 1 )
                {
                    return BadRequest(APIResponses.BadRequest("Invalid Id"));
                }

                var removedEntity = await _db._chronicDiseaseDrug.GetAsync(
                    expression: g => g.Id == id,
                    includeProperties: "ChronicDisease");

                if (removedEntity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No objects with Id = {id}"));
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

                    if (headerId != removedEntity.ChronicDisease.MedicalTeamId)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                await _db._chronicDiseaseDrug.DeleteAsync(removedEntity);

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
