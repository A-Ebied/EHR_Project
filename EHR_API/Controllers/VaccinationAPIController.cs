using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.VaccinationDTOs;
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


        [HttpGet("GetVaccinations")]
        public async Task<ActionResult<APIResponse>> GetVaccinations()
        {
            try
            {
                IEnumerable<Vaccination> entities = new List<Vaccination>();
                entities = await _db._vaccination.GetAllAsync();

                if (entities.ToList().Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                _response.Result = _mapper.Map<List<VaccinationDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<APIResponse>> GetVaccination(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id is < 1"));
                }

                var entity = await _db._vaccination.GetAsync(
                    expression: g => g.Id == id);

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with code = {id} "));
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

        [HttpPost("CreateVaccination")]
        [Authorize(Roles = SD.SystemManager)]
        public async Task<ActionResult<APIResponse>> CreateVaccination([FromBody] VaccinationCreateDTO entityCreateDTO)
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


        //[HttpDelete("{id}")]
        //[Authorize(Roles = SD.SystemManager)]
        //public async Task<ActionResult<APIResponse>> DeleteVaccination(int id)
        //{
        //    try
        //    {
        //        if (id < 1)
        //        {
        //            return BadRequest(APIResponses.BadRequest("Id is < 1"));
        //        }

        //        var removedEntity = await _db._vaccination.GetAsync(expression: g => g.Id == id);
        //        if (removedEntity == null)
        //        {
        //            return NotFound(APIResponses.NotFound($"No object with code = {id} "));
        //        }

        //        await _db._vaccination.DeleteAsync(removedEntity);

        //        _response.StatusCode = HttpStatusCode.OK;
        //        _response.Result = "The object has been deleted";
        //        return Ok(_response);
        //    }
        //    catch (Exception ex)
        //    {
        //        return APIResponses.InternalServerError(ex);
        //    }
        //}

        [HttpPut("{id}")]
        [Authorize(Roles = SD.SystemManager)]
        public async Task<ActionResult<APIResponse>> UpdateVaccination(int id, [FromBody] VaccinationUpdateDTO entityUpdateDTO)
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

                if (await _db._vaccination.GetAsync(expression: g => g.Id == id) == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
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
