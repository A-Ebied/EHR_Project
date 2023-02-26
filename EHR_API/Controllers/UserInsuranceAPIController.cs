using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.UserDataDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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

        /*
         * [HttpGet("GetUsersInsurances")]
        //[ResponseCache(CacheProfileName = SD.ProfileName)]
        //[Authorize]
        ////[Authorize(Roles = SD.SystemManager)]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<ActionResult<APIResponse>> GetUsersInsurances([FromQuery(Name = "InsuranceOrganizationName")] string name = null, int pageNumber = 1, int pageSize = 0)
        //{
        //    try
        //    {
        //        var entities = await _db._userInsurance.GetAllAsync(
        //            expression: name == null ? null : g => g.InsuranceOrganizationName.ToLower().Contains(name.ToLower()),
        //            pageNumber: pageNumber,
        //            pageSize: pageSize);

        //        if (entities.Count == 0)
        //        {
        //            return NotFound(APIResponses.NotFound("No data has been found"));
        //        }

        //        Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };
        //        Response.Headers.Add("Pagination", JsonSerializer.Serialize(pagination));

        //        _response.Result = _mapper.Map<List<UserInsurance>>(entities);
        //        _response.StatusCode = HttpStatusCode.OK;
        //        return Ok(_response);
        //    }
        //    catch (Exception ex)
        //    {
        //        return APIResponses.InternalServerError(ex);
        //    }
        /}
        */

        [Authorize]
        [HttpGet("{id}")]
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

                var entities = await _db._userInsurance.GetAllAsync(expression: g => g.RegistrationDataId == id);
                if (entities == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No objects with Id = {id} "));
                }

                _response.Result = _mapper.Map<List<UserInsuranceDTO>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize]
        [HttpGet("GetInsurance")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetInsurance([FromQuery(Name = "id")] int id)
        {
            try
            {
                if (id < 0)
                {
                    return BadRequest(APIResponses.BadRequest("Id is less than 1"));
                }

                var entities = await _db._userInsurance.GetAsync(expression: g => g.Id == id);
                if (entities == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id} "));
                }

                _response.Result = _mapper.Map<UserInsuranceDTO>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize]
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

                if (await _db._authentication.GetAsync(expression: e => e.Id == entityCreateDTO.RegistrationDataId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("User is not exists"));
                }

                if (await _db._userInsurance.GetAsync(expression: g => g.InsuranceNo.ToLower() == entityCreateDTO.InsuranceNo.ToLower()) != null)
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
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize]
        [HttpPost("CreateUserInsurances")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
                    if (await _db._authentication.GetAsync(expression: e => e.Id == item.RegistrationDataId) == null)
                    {
                        return BadRequest(APIResponses.BadRequest("User is not exists"));
                    }

                    if (await _db._userInsurance.GetAsync(expression: g => g.InsuranceNo.ToLower() == item.InsuranceNo.ToLower()) != null)
                    {
                        if (await _db._userInsurance.GetAsync(expression: g => g.InsuranceOrganizationName.ToLower() == item.InsuranceOrganizationName.ToLower()) != null)
                        {
                            return BadRequest(APIResponses.BadRequest("The object is already exists"));
                        }
                    }
                }

                var entities = _mapper.Map<List<UserInsurance>>(entityCreateDTOList._userInsurances);
                foreach (var item in entities)
                {
                    item.CreatedAt = DateTime.Now;
                    item.UpdateddAt = DateTime.Now;
                }
                await _db._userInsurance.CreateRangeAsync(entities);

                _response.Result = _mapper.Map<List<UserInsuranceDTO>>(entities);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize]
        [HttpDelete("{id:int}")]
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

        [Authorize]
        [HttpPut("{id:int}")]
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

                if (await _db._authentication.GetAsync(expression: e => e.Id == entityUpdateDTO.RegistrationDataId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("User is not exists"));
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
