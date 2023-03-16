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


        //[Authorize(Roles = SD.Physician + SD.Nurse + "," + SD.Technician + "," + SD.HealthFacilityManager)]
        //[Authorize]
        [HttpPost("CreateUserReceiveBloodDataData")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateUserReceiveBloodDataData([FromBody] ReceiveBloodDataCreateDTO entityCreateDTO)
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
