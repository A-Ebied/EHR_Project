using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.MedicationDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

namespace EHR_API.Controllers
{
    [Route("api/MedicationAPI")]
    [ApiController]
    public class MedicationAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public MedicationAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }

        //[Authorize(Roles = SD.SystemManager)]
        //[Authorize]
        [HttpPost("CreateMedication")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateMedication([FromBody] MedicationCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._medication.GetAsync(expression: g => g.Name.ToLower() == entityCreateDTO.Name.ToLower()) != null)
                {
                    return BadRequest(APIResponses.BadRequest("The object is already exists"));
                }

                var entity = _mapper.Map<Medication>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                await _db._medication.CreateAsync(entity);

                _response.Result = _mapper.Map<MedicationDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                 
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.SystemManager)]
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateMedication(int id, [FromBody] MedicationUpdateDTO entityUpdateDTO)
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

                var oldOne = await _db._medication.GetAsync(expression: g => g.Id == id);
                if (oldOne == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                var entity = _mapper.Map<Medication>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                entity.CreatedAt = oldOne.CreatedAt;
                await _db._medication.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<MedicationDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpGet("GetMedications")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetMedications([FromQuery(Name = "searchName")] string name = null, int pageNumber = 1, int pageSize = 0)
        {
            try
            {
                IEnumerable<Medication> entities = new List<Medication>();
                entities = await _db._medication.GetAllAsync(
                    expression: name == null ? null : g => g.Name.ToLower().Contains(name.ToLower()),
                    pageNumber: pageNumber,
                    pageSize: pageSize);

                if (entities.ToList().Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };
                Response.Headers.Add("Pagination", JsonSerializer.Serialize(pagination));

                _response.Result = _mapper.Map<List<MedicationDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpGet("{id}")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetMedication(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var entity = new Medication();
                entity = await _db._medication.GetAsync(
                   expression: g => g.Id == id);

                if (entity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }
 
                _response.Result =  _mapper.Map<MedicationDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.SystemManager)]
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteMedication(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var removedEntity = await _db._medication.GetAsync(expression: g => g.Id == id);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                await _db._medication.DeleteAsync(removedEntity);

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
