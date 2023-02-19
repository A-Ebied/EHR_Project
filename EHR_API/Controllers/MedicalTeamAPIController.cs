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
//    [Route("api/MedicalTeamAPI")]
//    [ApiController]
//    public class MedicalTeamAPIController : ControllerBase
//    {
//        protected APIResponse _response;
//        private readonly IMapper _mapper;
//        private readonly IMainRepository _db;

//        public MedicalTeamAPIController(IMainRepository db, IMapper mapper)
//        {
//            _db = db;
//            _mapper = mapper;
//            _response = new();
//        }

//        [HttpGet("GetMedicalTeamUsers")]
//        [ResponseCache(CacheProfileName = SD.ProfileName)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        public async Task<ActionResult<APIResponse>> GetMedicalTeamUsers([FromQuery(Name = "MedicalSpecialization")] string medicalSpecialization = null, int pageNumber = 1, int pageSize = 0)
//        {
//            try
//            {
//                var entities = await _db._medicalTeam.GetAllAsync(
//                    expression: medicalSpecialization == null ? null : g => g.MedicalSpecialization.ToLower().Contains(medicalSpecialization.ToLower()),
//                    pageNumber: pageNumber,
//                    pageSize: pageSize);

//                if (entities.Count == 0)
//                {
//                    return NotFound(APIResponses.NotFound("No data has been found"));
//                }

//                //List<RegistrationData> entities = new();
//                //foreach (var item in temp)
//                //{
//                //    entities.Add(
//                //        await _db._authentication.GetAsync(
//                //           expression: g => g.Id.ToLower().Contains(item.Id.ToLower()),
//                //           includeProperties: "PersonalData,MedicalTeam"));
//                //}

//                Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };
//                Response.Headers.Add("Pagination", JsonSerializer.Serialize(pagination));

//                _response.Result = _mapper.Map<List<MedicalDataDTO>>(entities);
//                _response.StatusCode = HttpStatusCode.OK;
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }

//        [HttpGet("{id}", Name = "GetMedicalTeamUser")]
//        [ResponseCache(CacheProfileName = SD.ProfileName)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        public async Task<ActionResult<APIResponse>> GetMedicalTeamUser(string id)
//        {
//            try
//            {
//                if (id == null)
//                {
//                    return BadRequest(APIResponses.BadRequest("Id is null"));
//                }

//                var entity = await _db._medicalData.GetAsync(
//                           expression: g => g.Id.ToLower().Contains(id.ToLower()));

//                if (entity == null)
//                {
//                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id} "));
//                }

//                _response.Result = _mapper.Map<RegistrationDataDTO>(entity);
//                _response.StatusCode = HttpStatusCode.OK;
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }

//        [Authorize(Roles = SD.HealthFacilitiesAdministrator + "," + SD.HealthFacilityManager)]
//        [HttpPost("CreateMedicalTeamUser")]
//        [ProducesResponseType(StatusCodes.Status201Created)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        public async Task<ActionResult<APIResponse>> CreateMedicalTeamUser([FromBody] MedicalTeamCreateDTO entityCreateDTO)
//        {
//            try
//            {
//                if (entityCreateDTO == null)
//                {
//                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
//                }

//                if (await _db._medicalTeam.GetAsync(expression: g => g.Id.ToLower() == entityCreateDTO.Id.ToLower()) != null)
//                {
//                    return BadRequest(APIResponses.BadRequest("The object is already exists"));
//                }

//                var entity = _mapper.Map<MedicalTeam>(entityCreateDTO);
//                await _db._medicalTeam.CreateAsync(entity);

//                _response.Result = _mapper.Map<MedicalTeamDTO>(entity);
//                _response.StatusCode = HttpStatusCode.Created;
//                return CreatedAtRoute("GetMedicalTeamUser", new { id = entity.Id }, _response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }

//        [Authorize(Roles = SD.HealthFacilitiesAdministrator + "," + SD.HealthFacilityManager)]
//        [HttpDelete("{id}", Name = "DeleteMedicalTeamUser")]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        public async Task<ActionResult<APIResponse>> DeleteMedicalTeamUser(string id)
//        {
//            try
//            {
//                if (id == null)
//                {
//                    return BadRequest(APIResponses.BadRequest("Id is null"));
//                }

//                var removedEntity = await _db._medicalTeam.GetAsync(expression: g => g.Id == id);
//                if (removedEntity == null)
//                {
//                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
//                }

//                await _db._medicalTeam.DeleteAsync(removedEntity);

//                _response.StatusCode = HttpStatusCode.OK;
//                _response.Result = "The object has been deleted";
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }

//        [Authorize(Roles = SD.HealthFacilitiesAdministrator + "," + SD.HealthFacilityManager)]
//        [HttpPut("{id}", Name = "UpdateMedicalTeamUser")]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        public async Task<ActionResult<APIResponse>> UpdateMedicalTeamUser(string id, [FromBody] MedicalTeamUpdateDTO entityUpdateDTO)
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

//                if (await _db._medicalTeam.GetAsync(expression: g => g.Id == id) == null)
//                {
//                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
//                }

//                var entity = _mapper.Map<MedicalTeam>(entityUpdateDTO);
//                entity.UpdateddAt = DateTime.Now;
//                await _db._medicalTeam.UpdateAsync(entity);

//                _response.StatusCode = HttpStatusCode.OK;
//                _response.Result = _mapper.Map<MedicalTeamDTO>(entity);
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }
//    }
//}
