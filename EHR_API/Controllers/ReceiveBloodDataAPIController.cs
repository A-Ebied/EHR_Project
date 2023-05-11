using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.ReceiveBloodDataDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;


namespace EHR_API.Controllers
{
    [Route("api/ReceiveBloodDataAPI")]
    [ApiController]
    public class ReceiveBloodDataAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public ReceiveBloodDataAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }


        [HttpGet("{id}")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> GetReceiveBloodData(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id is less than 1"));
                }

                /*
                string jwtToken = null;
                //if (HttpContext.Request.Headers.Authorization.Count > 0)
                //{
                //    jwtToken = HttpContext.Request.Headers.Authorization.ToString().Split(" ")[1];
                //}
                //var entity = new RegistrationData();
                //string headerRole = null;
                //string headerId = null;
                //if (jwtToken != null)
                //{
                //    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                //    headerRole = user.Claims.ToList()[4].Value;
                //    headerId = user.Claims.ToList()[0].Value;

                //    if (headerRole == SD.Physician || headerRole == SD.Nurse || headerRole == SD.HealthFacilityManager || headerRole == SD.Pharmacist || headerRole == SD.Technician || headerId == userId)
                //    {
                //        entity = await _db._authentication.GetAsync(
                //                 expression: g => g.Id == userId,
                //                 includeProperties: "PersonalData,MedicalData,MedicalTeam");
                //    }

                //}
                //else
                //{
                //    entity = await _db._authentication.GetAsync(
                //             expression: g => g.Id == userId,
                //             includeProperties: "PersonalData,MedicalTeam");
                }
                */

                var entity = await _db._receiveBloodData.GetAsync(expression: g => g.Id == id);

                if (entity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                _response.Result = _mapper.Map<ReceiveBloodDataDTOForOthers>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.Physician + SD.Nurse + "," + SD.Technician + "," + SD.HealthFacilityManager)]
        //[Authorize]
        [HttpPost("CreateUserReceiveBloodData")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateUserReceiveBloodData([FromBody] ReceiveBloodDataCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._receiveBloodData.GetAsync(expression: g => g.Id == entityCreateDTO.Id) != null)
                {
                    return BadRequest(APIResponses.BadRequest("The object is already exists"));
                }

                var entity = _mapper.Map<ReceiveBloodData>(entityCreateDTO);
                //entity.CreatedAt = DateTime.Now;
                //entity.UpdateddAt = DateTime.Now;
                await _db._receiveBloodData.CreateAsync(entity);

                _response.Result = _mapper.Map<ReceiveBloodDataDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.Pharmacist + "," + SD.Nurse + "," + SD.Technician + "," + SD.HealthFacilityManager)]
        //[Authorize]
        [HttpPut("UpdateUserReceiveBloodData")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateUserReceiveBloodData(int  id, [FromBody] ReceiveBloodDataUpdateDTO entityUpdateDTO)
        {
            try
            {
                if (entityUpdateDTO == null )
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (id != entityUpdateDTO.Id)
                {
                    return BadRequest(APIResponses.BadRequest("Id is not equal to the Id of the object"));
                }

                var oldOne = await _db._receiveBloodData.GetAsync(expression: g => g.Id == id);
                if (oldOne == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                var entity = _mapper.Map<ReceiveBloodData>(entityUpdateDTO);
               // entity.UpdateddAt = DateTime.Now;
                await _db._receiveBloodData.UpdateAsync(entity, oldOne);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<ReceiveBloodDataDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize(Roles = SD.Pharmacist + "," + SD.Nurse + "," + SD.Technician + "," + SD.HealthFacilityManager)]
        ////[Authorize]
        [HttpDelete("DeleteReceiveBloodData")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteReceiveBloodData(int id)
        {
            try
            {
                if (id==0 )
                {
                    return BadRequest(APIResponses.BadRequest("Invalid Ids"));
                }

                var removedEntity = await _db._receiveBloodData.GetAsync(
                    expression: g => g.Id == id);

                if (removedEntity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id}"));
                }

                await _db._receiveBloodData.DeleteAsync(removedEntity);

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
