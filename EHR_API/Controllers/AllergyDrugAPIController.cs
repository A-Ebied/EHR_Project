using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.AllergyDrugDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/AllergyDrugAPI")]
    [ApiController]
    public class AllergyDrugAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public AllergyDrugAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }

        /*
        //[Authorize]
        [HttpGet("GetAllergyDrug")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetAllergyDrug([FromQuery(Name = "allergyId")] int allergyId, [FromQuery(Name = "medicationId")] int medicationId)
        {
            try
            {
                if (allergyId < 0 || medicationId < 0)
                {
                    return BadRequest(APIResponses.BadRequest("Id is less than 1"));
                }

                var entity = await _db._allergyDrug.GetAsync(
                     includeProperties: "Medication,Allergy",
                    expression: g => g.AllergyId == allergyId && g.MedicationId == medicationId);

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with allergyId = {allergyId} and medicationId = {medicationId}"));
                }

                _response.Result = _mapper.Map<AllergyDrugDTO>(entity);
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
        [HttpGet("GetAllergyDrugs")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetAllergyDrugs(int allergyId)
        {
            try
            {
                if (allergyId < 0)
                {
                    return BadRequest(APIResponses.BadRequest("Id is less than 1"));
                }

                var entities = await _db._allergyDrug.GetAllAsync(
                     includeProperties: "Medication",
                    expression: g => g.AllergyId == allergyId);

                if (entities.Count == 0)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {allergyId}"));
                }

                _response.Result = _mapper.Map<List<AllergyDrugDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        ////[Authorize]
        [HttpPost("CreateAllergyDrugs")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateAllergyDrugs([FromBody] AllergyDrugsCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                foreach (var item in entityCreateDTO.AllergyDrugs)
                {
                    if (await _db._allergy.GetAsync(expression: e => e.Id == item.AllergyId) == null)
                    {
                        return BadRequest(APIResponses.BadRequest($"Allergy with id {item.AllergyId} is not exists"));
                    } 
                    
                    if (await _db._medication.GetAsync(expression: e => e.Id == item.MedicationId) == null)
                    {
                        return BadRequest(APIResponses.BadRequest($"Medication with id {item.MedicationId} is not exists"));
                    }
                }

                var entities = _mapper.Map<List<AllergyDrug>>(entityCreateDTO.AllergyDrugs);
                foreach (var item in entities)
                {
                    item.CreatedAt = DateTime.Now;
                    item.UpdatedAt = DateTime.Now;
                }
                await _db._allergyDrug.CreateRangeAsync(entities);

                _response.Result = _mapper.Map<List<AllergyDrugDTO>>(entities);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
 
        ////[Authorize]
        [HttpDelete("DeleteAllergyDrug")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteAllergyDrug(int allergyId, int medicationId)
        {
            try
            {
                if (allergyId < 0 || medicationId < 0)
                {
                    return BadRequest(APIResponses.BadRequest("Invalid Ids"));
                }

                var removedEntity = await _db._allergyDrug.GetAsync(
                    expression: g => g.AllergyId == allergyId && g.MedicationId == medicationId);

                if (removedEntity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with allergyId = {allergyId} and medicationId = {medicationId}"));
                }

                await _db._allergyDrug.DeleteAsync(removedEntity);

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
