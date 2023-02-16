using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.GovernorateDTOs;
using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Text.Json;

namespace EHR_API.Controllers
{
    [Route("api/GovernorateAPI")]
    [ApiController]
    public class GovernorateAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;
        
        public GovernorateAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }

        [HttpGet("GetGovernorates")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetGovernorates([FromQuery(Name = "searchTitle")]string title = null, int pageNumber = 1, int pageSize = 0, [FromHeader] string jwtToken = null) 
        {
            try
            {
                IEnumerable<Governorate> entities = new List<Governorate>();
                entities = await _db._governorate.GetAllAsync(
                                    includeProperties: "HealthFacilitys",
                                    expression: title == null ? null : g => g.Title.ToLower().Contains(title.ToLower()),
                                    pageNumber: pageNumber,
                                    pageSize: pageSize);

                if (entities.ToList().Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                if (jwtToken != null)
                {
                    string headerRole = null;
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerRole = user.Claims.ToList()[1].Value;

                    if (headerRole == SD.SystemManager)
                    {
                        entities = await _db._governorate.GetAllAsync(
                                         includeProperties: "HealthFacilitys,PersonalData",
                                         expression: title == null ? null : g => g.Title.ToLower().Contains(title.ToLower()),
                                         pageNumber: pageNumber,
                                         pageSize: pageSize);
                    }
                }
                
                Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };
                Response.Headers.Add("Pagination", JsonSerializer.Serialize(pagination));

                _response.Result = _mapper.Map<List<GovernorateDTO>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);                    
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpGet("{id:int}", Name = "GetGovernorate")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetGovernorate(int id, [FromHeader] string jwtToken = null)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var entity = new Governorate();
                 entity = await _db._governorate.GetAsync(
                    expression: g => g.Id == id, 
                    includeProperties: "HealthFacilitys");

                if (entity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                if (jwtToken != null)
                {
                    string headerRole = null;
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerRole = user.Claims.ToList()[1].Value;

                    if (headerRole == SD.SystemManager)
                    {
                        entity = await _db._governorate.GetAsync(
                                           expression: g => g.Id == id,
                                           includeProperties: "HealthFacilitys,PersonalData");
                    }
                }

                _response.Result = _mapper.Map<GovernorateDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize(Roles = SD.SystemManager)]
        [HttpPost("CreateGovernorate")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateGovernorate([FromBody] GovernorateCreateDTO entityCreateDTO) 
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._governorate.GetAsync(expression: g => g.Title!.ToLower() == entityCreateDTO.Title!.ToLower()) != null)
                {
                    return BadRequest(APIResponses.BadRequest("The object is already exists"));
                }

                var entity = _mapper.Map<Governorate>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdateddAt = DateTime.Now;
                await _db._governorate.CreateAsync(entity);

                _response.Result = _mapper.Map<GovernorateDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                // للعنصر الذي تم انشاءه response في url بيدي 
                return CreatedAtRoute("GetGovernorate", new { id = entity.Id }, _response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize(Roles = SD.SystemManager)]
        [HttpDelete("{id:int}", Name = "DeleteGovernorate")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteGovernorate(int id) 
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var removedEntity = await _db._governorate.GetAsync(expression: g => g.Id == id);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                await _db._governorate.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = "The object has been deleted";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize(Roles = SD.SystemManager)]
        [HttpPut("{id:int}", Name = "UpdateGovernorate")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateGovernorate(int id, [FromBody] GovernorateUpdateDTO entityUpdateDTO)
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

                if (await _db._governorate.GetAsync(expression: g => g.Id == id) == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                var entity = _mapper.Map<Governorate>(entityUpdateDTO);
                entity.UpdateddAt = DateTime.Now;
                await _db._governorate.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<GovernorateDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
    }
}
