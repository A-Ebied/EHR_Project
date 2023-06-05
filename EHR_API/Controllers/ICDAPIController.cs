using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.ICDDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
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


        [HttpGet("GetICDs")]
        //[Authorize(Roles = SD.SystemManager + "," + SD.HealthFacilityManager + "," + SD.Physician)]
        public async Task<ActionResult<APIResponse>> GetICDs()
        {
            try
            {
                IEnumerable<ICD> entities = new List<ICD>();
                entities = await _db._icd.GetAllAsync();

                if (entities.ToList().Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                _response.Result = _mapper.Map<List<ICDDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpGet("GetICD")]
        //[Authorize(Roles = SD.SystemManager + "," + SD.HealthFacilityManager + "," + SD.Physician)]
        public async Task<ActionResult<APIResponse>> GetICD(string code)
        {
            try
            {
                if (code == null)
                {
                    return BadRequest(APIResponses.BadRequest("code is null"));
                }

                var entity = await _db._icd.GetAsync(
                    expression: g => g.Code == code);

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with code = {code} "));
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

        [HttpPost("CreateICD")]
        //[Authorize(Roles = SD.SystemManager)]
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


        [HttpDelete("{code}")]
        [Authorize(Roles = SD.SystemManager)]
        public async Task<ActionResult<APIResponse>> DeleteICD(string code)
        {
            try
            {
                if (code == null)
                {
                    return BadRequest(APIResponses.BadRequest("code is null"));
                }

                var removedEntity = await _db._icd.GetAsync(expression: g => g.Code == code);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with code = {code} "));
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

        [HttpPut("{code}")]
        [Authorize(Roles = SD.SystemManager)]
        public async Task<ActionResult<APIResponse>> UpdateICD(string code, [FromBody] ICDUpdateDTO entityUpdateDTO)
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
