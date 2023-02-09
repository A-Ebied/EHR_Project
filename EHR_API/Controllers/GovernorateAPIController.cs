using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.Governorate;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EHR_API.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/GovernorateAPI")]
    [ApiController]
    public class GovernorateController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IGovernorateRepository _db;
        
        public GovernorateController(IGovernorateRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }

        [HttpGet]
        //[ProducesResponseType(200, Type = typeof(IEnumerable<GovernorateDTO>) )]
        //[ProducesResponseType(404)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetGovernorates() 
        {
            try
            {
                var governorates = await _db.GetAllAsync(track: false);
                if (governorates.Count == 0)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                _response.Result = _mapper.Map<List<GovernorateDTO>>(governorates);
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

        [HttpGet("{id:int}", Name = "GetGovernorate")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetGovernorate(int id)
        {
            try
            {
                if (id < 1)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                var governorate = await _db.GetAsync(exception: g => g.Id == id, track: false);
                if (governorate == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                _response.Result = _mapper.Map<GovernorateDTO>(governorate);
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
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateGovernorate([FromBody] GovernorateCreateDTO governorateDTO) 
        {
            try
            {
                if (governorateDTO == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                if (await _db.GetAsync(exception: g => g.Title!.ToLower() == governorateDTO.Title!.ToLower()) != null)
                {
                    ModelState.AddModelError("Create Governorate Error", "Governorate is already exists !");
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.Result = ModelState;
                    return BadRequest(_response);
                }

                var governorate = _mapper.Map<Governorate>(governorateDTO);
                await _db.CreateAsync(governorate);
                _response.Result = _mapper.Map<GovernorateDTO>(governorate);
                _response.StatusCode = HttpStatusCode.Created;

                // للعنصر الذي تم انشاءه response في url بيدي 
                return CreatedAtRoute("GetGovernorate", new { id = governorate.Id }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Errors = new List<string> { ex.ToString() };
                return _response;
            }
        }
        
        [HttpDelete("{id:int}", Name = "DeleteGovernorate")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<APIResponse>> DeleteGovernorate(int id) 
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                var removedGoveern = await _db.GetAsync(exception: g => g.Id == id);
                if (removedGoveern == null)
                {
                    return NotFound();
                }

                await _db.DeleteAsync(removedGoveern);

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


        [HttpPut("{id:int}", Name = "UpdateGovernorate")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<APIResponse>> UpdateGovernorate(int id, [FromBody] GovernorateUpdateDTO governorateDTO)
        {
            try
            {
                if (id != governorateDTO.Id || governorateDTO == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                if (await _db.GetAsync(exception: g => g.Id == id) == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                var governorate = _mapper.Map<Governorate>(governorateDTO);
                await _db.UpdateAsync(governorate);
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

        [HttpPatch("{id:int}", Name = "PatchGovernorate")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<APIResponse>> PatchGovernorate(int id, JsonPatchDocument<GovernorateUpdateDTO> governoratePatch)
        {
            try
            {
                if (id == 0 || governoratePatch == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                var governorate = await _db.GetAsync(exception: g => g.Id == id, track: false);
                if (governorate == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                var patch = _mapper.Map<GovernorateUpdateDTO>(governorate);
                governoratePatch.ApplyTo(patch, ModelState);
                if (!ModelState.IsValid)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.Result = ModelState;
                    return BadRequest(_response);
                }

                governorate = _mapper.Map<Governorate>(patch);
                await _db.UpdateAsync(governorate);
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
