using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.AllergyDrugDTOs;
using EHR_API.Entities.DTOs.ICDDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

namespace EHR_API.Controllers
{
    [Route("api/ICDAPI")]
    [ApiController]
    public class ICDAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public ICDAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }


        //[Authorize]
        [HttpGet("GetICDs")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetICDs([FromQuery(Name = "DiagnosisName")] string diagnosisName = null, int pageNumber = 1, int pageSize = 0)
        {
            try
            {
                IEnumerable<ICD> entities = new List<ICD>();
                entities = await _db._icd.GetAllAsync(
                    expression: diagnosisName == null ? null : g => g.DiagnosisName.ToLower().Contains(diagnosisName.ToLower()),
                    pageNumber: pageNumber,
                    pageSize: pageSize);

                if (entities.ToList().Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };
                Response.Headers.Add("Pagination", JsonSerializer.Serialize(pagination));

                _response.Result = _mapper.Map<List<ICDDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpGet("GetICD")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetAllergy([FromQuery(Name = "code")] string code)
        {
            try
            {
                if (code != null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var entity = await _db._icd.GetAsync(
                    expression: g => g.Code == code);

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {code} "));
                }

                _response.Result = _mapper.Map<ICDDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpPost("CreateICD")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateICD([FromBody] ICDCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }
                 
                var entity = _mapper.Map<ICD>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                await _db._icd.CreateAsync(entity);
                 
                _response.Result = _mapper.Map<ICDDTO>(entity);
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
        public async Task<ActionResult<APIResponse>> DeleteAllergy(string code)
        {
            try
            {
                if (code != null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var removedEntity = await _db._icd.GetAsync(expression: g => g.Code == code);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {code} "));
                }

                await _db._icd.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = "The object has been deleted";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateAllergy(string code, [FromBody] ICDUpdateDTO entityUpdateDTO)
        {
            try
            {
                if (entityUpdateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (code != entityUpdateDTO.Code)
                {
                    return BadRequest(APIResponses.BadRequest("Code is not equal to the Code of the object"));
                }

                if (await _db._icd.GetAsync(expression: g => g.Code == code) == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {code} "));
                }
                 
                var entity = _mapper.Map<ICD>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                await _db._icd.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<ICDDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
    }
}
