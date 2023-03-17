using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.ChronicDiseaseDrugDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
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
        [HttpGet("GetChronicDiseaseDrugs")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetChronicDiseaseDrugs(int chronicDiseaseId)
        {
            try
            {
                if (chronicDiseaseId < 1 )
                {
                    return BadRequest(APIResponses.BadRequest("Ids is < 1 "));
                }

                var entities = await _db._chronicDiseaseDrug.GetAllAsync(
                    expression: g => g.ChronicDiseaseId == chronicDiseaseId);

                if (entities.Count == 0)
                {
                    return BadRequest(APIResponses.BadRequest($"No objects with Id = {chronicDiseaseId}"));
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

        //[Authorize]
        [HttpPost("CreateChronicDiseaseDrugs")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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


        //[Authorize]
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteChronicDiseaseDrug(int id)
        {
            try
            {
                if (id < 1 )
                {
                    return BadRequest(APIResponses.BadRequest("Invalid Id"));
                }

                var removedEntity = await _db._chronicDiseaseDrug.GetAsync(
                    expression: g => g.Id == id);

                if (removedEntity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No objects with Id = {id}"));
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
