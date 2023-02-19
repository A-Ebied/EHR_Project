//using AutoMapper;
//using EHR_API.Entities;
//using EHR_API.Entities.DTOs.UserDataDTOs;
//using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration;
//using EHR_API.Entities.Models.UsersData;
//using EHR_API.Extensions;
//using EHR_API.Repositories.Contracts;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using System.Net;
//using System.Text.Json;

//namespace EHR_API.Controllers
//{
//    [Authorize]
//    [Route("api/PersonalDataAPI")]
//    [ApiController]
//    public class PersonalDataAPIController : ControllerBase
//    {
//        protected APIResponse _response;
//        private readonly IMapper _mapper;
//        private readonly IMainRepository _db;

//        public PersonalDataAPIController(IMainRepository db, IMapper mapper)
//        {
//            _db = db;
//            _mapper = mapper;
//            _response = new();
//        }

//        //[Authorize(Roles = SD.SystemManager + "," + SD.HealthFacilityManager)]
//        //[HttpGet("GetUsersPersonalData")]
//        //[ResponseCache(CacheProfileName = SD.ProfileName)]
//        //[ProducesResponseType(StatusCodes.Status200OK)]
//        //[ProducesResponseType(StatusCodes.Status404NotFound)]
//        //public async Task<ActionResult<APIResponse>> GetUsersPersonalData([FromQuery(Name = "searchId")]string id = null, int pageNumber = 1, int pageSize = 0) 
//        //{
//        //    try
//        //    {
//        //        var entities = await _db._personal.GetAllAsync(
//        //            expression: id==null? null : g => g.Id.ToLower().Contains(id.ToLower()),
//        //            pageNumber: pageNumber,
//        //            pageSize: pageSize);
                 
//        //        if (entities.Count  == 0)
//        //        {
//        //            return NotFound(APIResponses.NotFound("No data has been found"));
//        //        }

//        //        Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize};
//        //        Response.Headers.Add("Pagination", JsonSerializer.Serialize(pagination));

//        //        _response.Result = _mapper.Map<List<PersonalData>>(entities);
//        //        _response.StatusCode = HttpStatusCode.OK;
//        //        return Ok(_response);
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        return APIResponses.InternalServerError(ex);
//        //    }
//        //}

//        [Authorize]
//        [HttpGet("{id}", Name = "GetUserPersonalData")]
//        [ResponseCache(CacheProfileName = SD.ProfileName)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        public async Task<ActionResult<APIResponse>> GetUserPersonalData(string id)
//        {
//            try
//            {
//                if (id == null)
//                {
//                    return BadRequest(APIResponses.BadRequest("Id is null"));
//                }

//                var entity = await _db._personal.GetAsync(expression: g => g.Id == id);
//                if (entity == null)
//                {
//                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id} "));
//                }

//                _response.Result = _mapper.Map<PersonalDataDTO>(entity);
//                _response.StatusCode = HttpStatusCode.OK;
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }


//        [HttpPost("CreateUserPersonalData")]
//        [ProducesResponseType(StatusCodes.Status201Created)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        public async Task<ActionResult<APIResponse>> CreateUserPersonalData([FromBody] PersonalDataCreateDTO entityCreateDTO) 
//        {
//            try
//            {
//                if (entityCreateDTO == null)
//                {
//                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
//                }

//                if (await _db._governorate.GetAsync(expression: e => e.Id == entityCreateDTO.GovernorateId) == null)
//                {
//                    return BadRequest(APIResponses.BadRequest("Governorate is not exists"));
//                }

//                if (await _db._personal.GetAsync(expression: g => g.Id.ToLower() == entityCreateDTO.Id.ToLower()) != null)
//                {
//                    return BadRequest(APIResponses.BadRequest("The object is already exists"));
//                }

//                var entity = _mapper.Map<PersonalData>(entityCreateDTO);
//                await _db._personal.CreateAsync(entity);

//                _response.Result = _mapper.Map<PersonalDataDTO>(entity);
//                _response.StatusCode = HttpStatusCode.Created;
//                return CreatedAtRoute("GetUserPersonalData", new { id = entity.Id }, _response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }
        
//        [HttpDelete("{id}", Name = "DeletePersonalData")]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        public async Task<ActionResult<APIResponse>> DeletePersonalData(string id) 
//        {
//            try
//            {
//                if (id == null)
//                {
//                    return BadRequest(APIResponses.BadRequest("Id is null"));
//                }

//                var removedEntity = await _db._personal.GetAsync(expression: g => g.Id == id);
//                if (removedEntity == null)
//                {
//                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
//                }

//                await _db._personal.DeleteAsync(removedEntity);

//                _response.StatusCode = HttpStatusCode.OK;
//                _response.Result = "The object has been deleted";
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }


//        [HttpPut("{id}", Name = "UpdateUserPersonalData")]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        public async Task<ActionResult<APIResponse>> UpdateUserPersonalData(string id, [FromBody] PersonalDataUpdateDTO entityUpdateDTO)
//        {
//            try
//            {
//                if (entityUpdateDTO == null)
//                {
//                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
//                }

//                if (id != entityUpdateDTO.Id)
//                {
//                    return BadRequest(APIResponses.BadRequest("Id is not equal to the Id of the object"));
//                }

//                var oldEntity = await _db._personal.GetAsync(expression: g => g.Id == id);
//                if (oldEntity == null)
//                {
//                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
//                }
 
//                var entity = _mapper.Map<PersonalData>(entityUpdateDTO);
//                entity.UpdateddAt = DateTime.Now;
//                await _db._personal.UpdateAsync(entity, oldEntity);

//                _response.StatusCode = HttpStatusCode.OK;
//                _response.Result = _mapper.Map<PersonalDataDTO>(entity);
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }
//    }
//}
