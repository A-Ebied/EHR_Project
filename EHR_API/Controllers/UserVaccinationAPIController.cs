using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.UserVaccinationDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/UserVaccinationAPI")]
    [ApiController]
    public class UserVaccinationAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public UserVaccinationAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }

        //[Authorize(Roles = SD.SystemManager + "," + SD.HealthFacilityManager)]
        [HttpPost("CreateUserVaccination")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateUserVaccination([FromBody] UserVaccinationCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._visit.GetAsync(expression: e => e.Id == entityCreateDTO.VisitId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Visit is not exists"));
                }

                if (await _db._vaccination.GetAsync(expression: e => e.Code == entityCreateDTO.VaccinationId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Vaccination is not exists"));
                }

                var entity = _mapper.Map<UserVaccination>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                await _db._userVaccination.CreateAsync(entity);

                _response.Result = _mapper.Map<UserVaccinationDTOForOthers>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpGet("GetVisitVaccinations")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetVisitVaccinations(int visitId)
        {
            try
            {
                var entities = await _db._userVaccination.GetAllAsync(
                    expression: visitId == 0 ? null : g => g.VisitId == visitId);

                if (entities.Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                _response.Result = _mapper.Map<List<UserVaccinationDTOForOthers>>(entities);
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
        public async Task<ActionResult<APIResponse>> GetUserVaccination(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var entity = await _db._userVaccination.GetAsync(
                    expression: g => g.Id == id);

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id}"));
                }

                _response.Result = _mapper.Map<UserVaccinationDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpGet("GetUserVaccinations")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetUserVaccinations(string userId)
        {
            return BadRequest(APIResponses.BadRequest("Not work yet"));
            //try
            //{
            //    if (id < 1)
            //    {
            //        return BadRequest(APIResponses.BadRequest("Id less than 1"));
            //    }

            //    var entity = await _db._userVaccination.GetAsync(
            //        expression: g => g.Id == id);

            //    if (entity == null)
            //    {
            //        return BadRequest(APIResponses.BadRequest($"No object with Id = {id}"));
            //    }

            //    _response.Result = _mapper.Map<UserVaccinationDTO>(entity);
            //    _response.StatusCode = HttpStatusCode.OK;
            //    return Ok(_response);
            //}
            //catch (Exception ex)
            //{
            //    return APIResponses.InternalServerError(ex);
            //}
        }

        //[Authorize(Roles = SD.SystemManager + "," + SD.HealthFacilityManager)]
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateUserVaccination(int id, [FromBody] UserVaccinationUpdateDTO entityUpdateDTO)
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

                var oldOne = await _db._userVaccination.GetAsync(
                    expression: g => g.Id == id);
                if (oldOne == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id}"));
                }

                if (await _db._visit.GetAsync(expression: e => e.Id == entityUpdateDTO.VisitId) == null)
                {
                    return NotFound(APIResponses.NotFound($"No Visit with Id = {entityUpdateDTO.VisitId}"));
                }
                
                if (await _db._vaccination.GetAsync(expression: e => e.Code == entityUpdateDTO.VaccinationId) == null)
                {
                    return NotFound(APIResponses.NotFound($"No Vaccination with code = {entityUpdateDTO.VaccinationId}"));
                }

                var entity = _mapper.Map<UserVaccination>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                entity.CreatedAt = oldOne.CreatedAt;
                await _db._userVaccination.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<UserVaccinationDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.SystemManager + "," + SD.HealthFacilityManager)]
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteUserVaccination(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Ids less than 1"));
                }

                var removedEntity = await _db._physicalTherapy.GetAsync(
                    expression: g => g.Id == id);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id}"));
                }

                await _db._physicalTherapy.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
    }
}
