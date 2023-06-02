using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.GovernorateDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs;
using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/GovernorateAPI")]
    [ApiController]
    public class GovernorateAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;
        private readonly UserManager<RegistrationData> _userManager;

        public GovernorateAPIController(IMainRepository db, IMapper mapper, UserManager<RegistrationData> userManager = null)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
            _userManager = userManager;
        }

        [HttpPost("CreateGovernorate")]
        [Authorize(Roles = SD.SystemManager)]
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
                entity.UpdatedAt = DateTime.Now;
                await _db._governorate.CreateAsync(entity);

                _response.Result = _mapper.Map<GovernorateDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                 
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpPut("{id}")]
        [Authorize(Roles = SD.SystemManager)]
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

                var oldOne = await _db._governorate.GetAsync(expression: g => g.Id == id);
                if (oldOne == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                var entity = _mapper.Map<Governorate>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                entity.CreatedAt = oldOne.CreatedAt;
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

        [HttpGet("GetGovernorates")]
        public async Task<ActionResult<APIResponse>> GetGovernorates([FromQuery(Name = "searchTitle")] string title = null)
        {
            try
            {
                IEnumerable<Governorate> entities = new List<Governorate>();
                entities = await _db._governorate.GetAllAsync(
                    expression: title == null ? null : g => g.Title.ToLower().Contains(title.ToLower()));

                if (entities.ToList().Count == 0)
                {
                    return NotFound(APIResponses.NotFound("No data has been found"));
                }

                _response.Result = _mapper.Map<List<GovernorateDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<APIResponse>> GetGovernorate(int id)
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
                   includeProperties: "HealthFacilitys,PersonalData");

                if (entity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                var temp = await _db._medicalTeam.GetAllAsync();
                var medicalMem = new RegistrationData();
                var users = new List<UserDTOForOthers>();
                var role = "";
                foreach (var item in entity.PersonalData)
                {
                    if (temp.FirstOrDefault(t => t.Id == item.Id) != null)
                    {
                        medicalMem = await _db._authentication.GetAsync(
                            includeProperties: "MedicalTeam",
                            expression: r => r.Id == item.Id);
                        medicalMem.PersonalData = item;

                        role = _userManager.GetRolesAsync(medicalMem).Result.FirstOrDefault();
                        users.Add(APIResponses.User(medicalMem, role));
                    }
                }

                var result = _mapper.Map<GovernorateDTO>(entity);
                result.Users = users;
                _response.Result = result;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = SD.SystemManager)]
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
    }
}
