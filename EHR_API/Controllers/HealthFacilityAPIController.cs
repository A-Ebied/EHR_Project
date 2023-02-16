using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.HealthFacilityDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

namespace EHR_API.Controllers
{
    [Route("api/HealthFacilityAPI")]
    [ApiController]
    public class HealthFacilityAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public HealthFacilityAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }

        [HttpGet("GetHealthFacilities")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetHealthFacilities([FromQuery(Name = "searchTitle")] string title = null, int pageNumber = 1, int pageSize = 0) 
        {
            try
            {
                var entities = await _db._healthFacility.GetAllAsync(
                    expression: title == null ? null : g => g.Title.ToLower().Contains(title.ToLower()),
                    pageNumber: pageNumber,
                    pageSize: pageSize
                    );

                if (entities.Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };
                Response.Headers.Add("Pagination", JsonSerializer.Serialize(pagination));

                _response.Result = _mapper.Map<List<HealthFacilityDTO>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpGet("{id}", Name = "GetHealthFacility")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetHealthFacility(string id)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var entity = await _db._healthFacility.GetAsync(expression: g => g.Id == id, includeProperties: "Governorate");
                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id} "));
                }

                _response.Result = _mapper.Map<HealthFacilityDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpPost("CreateHealthFacility")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateHealthFacility([FromBody] HealthFacilityCreateDTO entityCreateDTO) 
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._healthFacility.GetAsync(expression: g => g.Title!.ToLower() == entityCreateDTO.Title!.ToLower()) != null)
                {
                    return BadRequest(APIResponses.BadRequest("The object is already exists"));
                }

                if (await _db._governorate.GetAsync(expression: e => e.Id == entityCreateDTO.GovernorateId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Governorate is not exists"));
                }

                var entity = _mapper.Map<HealthFacility>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdateddAt = DateTime.Now;
                await _db._healthFacility.CreateAsync(entity);

                _response.Result = _mapper.Map<HealthFacilityDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetHealthFacility", new { id = entity.Id }, _response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
        
        [HttpDelete("{id}", Name = "DeleteHealthFacility")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteHealthFacility(string id) 
        {
            try
            {
                if (id == null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var removedEntity = await _db._healthFacility.GetAsync(expression: g => g.Id == id);
                if (removedEntity == null)
                {             
                    return NotFound(APIResponses.NotFound( $"No object with Id = {id} "));
                }

                await _db._healthFacility.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        [HttpPut("{id}", Name = "UpdateHealthFacility")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateHealthFacility(string id, [FromBody] HealthFacilityUpdateDTO entityUpdateDTO)
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

                if (await _db._healthFacility.GetAsync(expression: g => g.Id == id) == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                if (await _db._governorate.GetAsync(expression: e => e.Id == entityUpdateDTO.GovernorateId) == null)
                {
                    return NotFound(APIResponses.NotFound($"No Governorate with Id = {entityUpdateDTO.GovernorateId}"));
                }

                var entity = _mapper.Map<HealthFacility>(entityUpdateDTO);
                entity.UpdateddAt = DateTime.Now;
                await _db._healthFacility.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<HealthFacilityDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

    }
}
