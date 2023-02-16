using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.UserDataDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

namespace EHR_API.Controllers
{
    [Route("api/UserInsuranceAPI")]
    [ApiController]
    public class UserInsuranceAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;
        
        public UserInsuranceAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }

        [HttpGet("GetUsersInsurance")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        //[Authorize]
        //[Authorize(Roles = SD.SystemManager)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetUsersInsurance([FromQuery(Name = "InsuranceOrganizationName")]string name = null, int pageNumber = 1, int pageSize = 0) 
        {
            try
            {
                var entities = await _db._userInsurance.GetAllAsync(
                    expression: name==null? null : g => g.InsuranceOrganizationName.ToLower().Contains(name.ToLower()),
                    pageNumber: pageNumber,
                    pageSize: pageSize);
                 
                if (entities.Count  == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize};
                Response.Headers.Add("Pagination", JsonSerializer.Serialize(pagination));

                _response.Result = _mapper.Map<List<UserInsurance>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpGet("{id}", Name = "GetUserInsurances")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetUserInsurances(string id)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var entity = await _db._userInsurance.GetAsync(expression: g => g.InsuranceDataId == id);
                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id} "));
                }

                _response.Result = _mapper.Map<UserInsuranceDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpPost("CreateUserInsurance")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateUserInsurance([FromBody] UserInsuranceCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._insuranceData.GetAsync(expression: e => e.Id == entityCreateDTO.InsuranceDataId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Insurance Data is not exists"));
                }

                if (await _db._userInsurance.GetAsync(expression: g => g.InsuranceDataId.ToLower() == entityCreateDTO.InsuranceDataId.ToLower()) != null)
                {
                    if (await _db._userInsurance.GetAsync(expression: g => g.InsuranceOrganizationName.ToLower() == entityCreateDTO.InsuranceOrganizationName.ToLower()) != null)
                    {
                        return BadRequest(APIResponses.BadRequest("The object is already exists"));
                    }
                }

                var entity = _mapper.Map<UserInsurance>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdateddAt = DateTime.Now;
                await _db._userInsurance.CreateAsync(entity);

                _response.Result = _mapper.Map<UserInsuranceDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetUserInsurances", new { id = entity.InsuranceDataId }, _response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpPost("CreateUserInsurances")]
        public async Task<ActionResult<APIResponse>> CreateUserInsurances([FromBody] UserInsurancesCreateDTO entityCreateDTOList)
        {
            try
            {
                if (entityCreateDTOList == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                foreach (var item in entityCreateDTOList._userInsurances)
                {
                    if (await _db._insuranceData.GetAsync(expression: e => e.Id == item.InsuranceDataId) == null)
                    {
                        return BadRequest(APIResponses.BadRequest("Insurance Data is not exists"));
                    }

                    if (await _db._userInsurance.GetAsync(expression: g => g.InsuranceDataId.ToLower() == item.InsuranceDataId.ToLower()) != null)
                    {
                        if (await _db._userInsurance.GetAsync(expression: g => g.InsuranceOrganizationName.ToLower() == item.InsuranceOrganizationName.ToLower()) != null)
                        {
                            return BadRequest(APIResponses.BadRequest("The object is already exists"));
                        }
                    }
                }

                var entities = _mapper.Map<List<UserInsurance>>(entityCreateDTOList);
                await _db._userInsurance.CreateRangeAsync(entities);

                _response.Result = _mapper.Map<List<UserInsuranceDTO>>(entities);
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetUserInsurances", new { id = entities[0].InsuranceDataId }, _response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpDelete("{id:int}", Name = "DeleteUserInsurance")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteUserInsurance(int id) 
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var removedEntity = await _db._userInsurance.GetAsync(expression: g => g.Id == id);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                await _db._userInsurance.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = "The object has been deleted";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpPut("{id:int}", Name = "UpdateUserInsurance")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateUserInsurance(int id, [FromBody] UserInsuranceUpdateDTO entityUpdateDTO)
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

                if (await _db._userInsurance.GetAsync(expression: g => g.Id == id) == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                if (await _db._insuranceData.GetAsync(expression: e => e.Id == entityUpdateDTO.InsuranceDataId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Insurance Data is not exists"));
                }

                var entity = _mapper.Map<UserInsurance>(entityUpdateDTO);
                entity.UpdateddAt = DateTime.Now;
                await _db._userInsurance.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<UserInsuranceDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
    }
}
