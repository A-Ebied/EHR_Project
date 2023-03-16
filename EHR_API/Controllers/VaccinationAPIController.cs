﻿using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.VaccinationDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

namespace EHR_API.Controllers
{
    [Route("api/VaccinationPI")]
    [ApiController]
    public class VaccinationAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public VaccinationAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }


        //[Authorize]
        [HttpGet("GetVaccinations")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetICDs(string type = null, int pageNumber = 1, int pageSize = 0)
        {
            try
            {
                IEnumerable<Vaccination> entities = new List<Vaccination>();
                entities = await _db._vaccination.GetAllAsync(
                    expression: type == null ? null : g => g.Type.ToLower().Contains(type.ToLower()),
                    pageNumber: pageNumber,
                    pageSize: pageSize);

                if (entities.ToList().Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };
                Response.Headers.Add("Pagination", JsonSerializer.Serialize(pagination));

                _response.Result = _mapper.Map<List<VaccinationDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpGet("{code}")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetVaccination(string code)
        {
            try
            {
                if (code == null)
                {
                    return BadRequest(APIResponses.BadRequest("code is null"));
                }

                var entity = await _db._vaccination.GetAsync(
                    expression: g => g.Code == code);

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with code = {code} "));
                }

                _response.Result = _mapper.Map<VaccinationDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpPost("CreateVaccination")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateICD([FromBody] VaccinationCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }
                 
                var entity = _mapper.Map<Vaccination>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                await _db._vaccination.CreateAsync(entity);
                 
                _response.Result = _mapper.Map<VaccinationDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        //[Authorize]
        [HttpDelete("{code}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteVaccination(string code)
        {
            try
            {
                if (code == null)
                {
                    return BadRequest(APIResponses.BadRequest("code is null"));
                }

                var removedEntity = await _db._vaccination.GetAsync(expression: g => g.Code == code);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with code = {code} "));
                }

                await _db._vaccination.DeleteAsync(removedEntity);

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
        [HttpPut("{code}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateICD(string code, [FromBody] VaccinationUpdateDTO entityUpdateDTO)
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

                if (await _db._vaccination.GetAsync(expression: g => g.Code == code) == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {code} "));
                }
                 
                var entity = _mapper.Map<Vaccination>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                await _db._vaccination.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<VaccinationDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
    }
}