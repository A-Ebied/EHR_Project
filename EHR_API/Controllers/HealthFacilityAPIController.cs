using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.HealthFacilityDTOs;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/HealthFacilityAPI")]
    [ApiController]
    public class HealthFacilityController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IHealthFacilityRepository _db;
        private readonly IGovernorateRepository _dbGov;
        
        public HealthFacilityController(IHealthFacilityRepository db, IMapper mapper, IGovernorateRepository dbGov)
        {
            _db = db;
            _dbGov = dbGov;
            _mapper = mapper;
            _response = new();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetHealthFacilities() 
        {
            try
            {
                var entities = await _db.GetAllAsync(track: false, includeProperties: "Governorate");
                if (entities.Count == 0)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                _response.Result = _mapper.Map<List<HealthFacilityDTO>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Errors = new List<string> { ex.ToString() };
                return _response;
            }
        }

        [HttpGet("{id:int}", Name = "GetHealthFacility")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetHealthFacility(int id)
        {
            try
            {
                if (id < 1)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                var entity = await _db.GetAsync(exception: g => g.Id == id, track: false, includeProperties: "Governorate");
                if (entity == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                _response.Result = _mapper.Map<HealthFacilityDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Errors = new List<string> { ex.ToString() };
                return _response;
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateHealthFacility([FromBody] HealthFacilityCreateDTO entityCreateDTO) 
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                if (await _db.GetAsync(exception: g => g.Title!.ToLower() == entityCreateDTO.Title!.ToLower()) != null)
                {
                    ModelState.AddModelError("Create Health Facility Error", "Health Facility is already exists !");
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.Result = ModelState;
                    return BadRequest(_response);
                }
                
                if (await _dbGov.GetAsync(exception: e => e.Id == entityCreateDTO.GovernorateId) == null)
                {
                    ModelState.AddModelError("Create Health Facility Error", "Governorate is not exists !");
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.Result = ModelState;
                    return BadRequest(_response);
                }

                var entity = _mapper.Map<HealthFacility>(entityCreateDTO);
                await _db.CreateAsync(entity);
                _response.Result = _mapper.Map<HealthFacilityDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;

                // للعنصر الذي تم انشاءه response في url بيدي 
                return CreatedAtRoute("GetGovernorate", new { id = entity.Id }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Errors = new List<string> { ex.ToString() };
                return _response;
            }
        }
        
        [HttpDelete("{id:int}", Name = "DeleteHealthFacility")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteHealthFacility(int id) 
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                var removedEntity = await _db.GetAsync(exception: g => g.Id == id);
                if (removedEntity == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                await _db.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.NoContent;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Errors = new List<string> { ex.ToString() };
                return _response;
            }
        }


        [HttpPut("{id:int}", Name = "UpdateHealthFacility")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateHealthFacility(int id, [FromBody] HealthFacilityUpdateDTO entityUpdateDTO)
        {
            try
            {
                if (id != entityUpdateDTO.Id || entityUpdateDTO == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                if (await _db.GetAsync(exception: g => g.Id == id) == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                if (await _dbGov.GetAsync(exception: e => e.Id == entityUpdateDTO.GovernorateId) == null)
                {
                    ModelState.AddModelError("Update Health Facility Error", "Governorate is not exists !");
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.Result = ModelState;
                    return BadRequest(_response);
                }

                var entity = _mapper.Map<HealthFacility>(entityUpdateDTO);
                await _db.UpdateAsync(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Errors = new List<string> { ex.ToString() };
                return _response;
            }
        }

    }
}
