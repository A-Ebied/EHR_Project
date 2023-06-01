using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.AllergyDrugDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Authorization;
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

        
        [HttpPost("CreateAllergyDrugs")]
        [Authorize(Roles = SD.HealthFacilityManager + "," + SD.Physician)]
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

        [HttpDelete("{id}")]   
        [Authorize(Roles = SD.HealthFacilityManager + "," + SD.Physician)]
        public async Task<ActionResult<APIResponse>> DeleteAllergyDrug(int id)
        {
            try
            {
                if (id < 0)
                {
                    return BadRequest(APIResponses.BadRequest("Invalid Id"));
                }

                var removedEntity = await _db._allergyDrug.GetAsync(
                    expression: g => g.Id == id);

                if (removedEntity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id}"));
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
