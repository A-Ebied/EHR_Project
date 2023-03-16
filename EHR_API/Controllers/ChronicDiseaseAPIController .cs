using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.ChronicDiseaseDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/ChronicDiseaseAPI")]
    [ApiController]
    public class ChronicDiseaseAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public ChronicDiseaseAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }


        //[Authorize]
        [HttpGet("GetUserChronicDiseases")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetUserChronicDiseases(string userId)
        {
            try
            {
                if (userId == null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var entities = await _db._chronicDisease.GetAllAsync(
                    expression: g => g.RegistrationDataId == userId );
                if (entities.Count == 0)
                {
                    return BadRequest(APIResponses.BadRequest($"No objects with Id = {userId} "));
                }

                _response.Result = _mapper.Map<List<ChronicDiseaseDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpGet("GetChronicDisease")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetChronicDisease(string iCDId,string userId)
        {
            try
            {
                if (iCDId==null || userId==null)
                {
                    return BadRequest(APIResponses.BadRequest("Ids are Null"));
                }

                var entity = await _db._chronicDisease.GetAsync(
                    expression: g => g.ICDId == iCDId && g.RegistrationDataId==userId);

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Ids = {userId} and {iCDId} "));
                }

                _response.Result = _mapper.Map<ChronicDiseaseDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpPost("CreateChronicDisease")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateChronicDisease([FromBody] ChronicDiseaseCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._authentication.GetAsync(expression: e => e.Id == entityCreateDTO.RegistrationDataId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("User is not exists"));
                }

                if (await _db._icd.GetAsync(expression: e => e.Code == entityCreateDTO.ICDId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("ICD is not exists"));
                }

                var entity = _mapper.Map<ChronicDisease>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                await _db._chronicDisease.CreateAsync(entity);

                if (entityCreateDTO.ChronicDiseaseDrugs != null)
                {
                    await _db._chronicDiseaseDrug.CreateRangeAsync(
                        _mapper.Map<List<ChronicDiseaseDrug>>(entityCreateDTO.ChronicDiseaseDrugs.ToList()));
                }

                _response.Result = _mapper.Map<ChronicDiseaseDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        //[Authorize]
        [HttpDelete("DeleteChronicDisease")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteChronicDisease(string iCDId, string userId)
        {
            try
            {
                if (iCDId==null || userId==null)
                {
                    return BadRequest(APIResponses.BadRequest("Ids are NULL"));
                }

                var removedEntity = await _db._chronicDisease.GetAsync(
                    expression: g => g.ICDId ==iCDId && g.RegistrationDataId==userId);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {iCDId}  and {userId}"));
                }

                await _db._chronicDisease.DeleteAsync(removedEntity);

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
        [HttpPut("UpdateChronicDisease")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateChronicDisease(string iCDId,string userId, [FromBody] ChronicDiseaseUpdateDTO entityUpdateDTO)
        {
            try
            {
                if (entityUpdateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (userId != entityUpdateDTO.RegistrationDataId )
                {
                    return BadRequest(APIResponses.BadRequest("Id is not equal to the Id of the object"));
                }

                if (await _db._chronicDisease.GetAsync(
                    expression: g => g.ICDId == iCDId && g.RegistrationDataId ==userId)  == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {iCDId} and {userId}"));
                }

                var entity = _mapper.Map<ChronicDisease>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                await _db._chronicDisease.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<ChronicDiseaseDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);

            }
        }
    }
}
