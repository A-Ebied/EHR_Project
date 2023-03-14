using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.UserDataDTOs.MedicalTeamDTOs;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/MedicalTeamAPI")]
    [ApiController]
    public class MedicalTeamAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public MedicalTeamAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }

        //[Authorize(Roles = SD.HealthFacilityManager)]
        //[Authorize]
        [HttpPost("CreateMedicalTeamUser")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateMedicalTeamUser([FromBody] MedicalTeamCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._medicalTeam.GetAsync(expression: g => g.Id.ToLower() == entityCreateDTO.Id.ToLower()) != null)
                {
                    return BadRequest(APIResponses.BadRequest("The object is already exists"));
                }

                var entity = _mapper.Map<MedicalTeam>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                await _db._medicalTeam.CreateAsync(entity);

                _response.Result = _mapper.Map<MedicalTeamDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.HealthFacilityManager)]
        //[Authorize]
        [HttpDelete("{userId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteMedicalTeamUser(string userId)
        {
            try
            {
                if (userId == null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var removedEntity = await _db._medicalTeam.GetAsync(expression: g => g.Id == userId);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {userId} "));
                }

                await _db._medicalTeam.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = "The object has been deleted";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.HealthFacilityManager)]
        //[Authorize]
        [HttpPut("{userId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateMedicalTeamUser(string userId, [FromBody] MedicalTeamUpdateDTO entityUpdateDTO)
        {
            try
            {
                if (entityUpdateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (userId != entityUpdateDTO.Id)
                {
                    return BadRequest(APIResponses.BadRequest("Id is not equal to the Id of the object"));
                }

                if (await _db._medicalTeam.GetAsync(expression: g => g.Id == userId) == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {userId} "));
                }

                var entity = _mapper.Map<MedicalTeam>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                await _db._medicalTeam.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<MedicalTeamDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
    }
}
