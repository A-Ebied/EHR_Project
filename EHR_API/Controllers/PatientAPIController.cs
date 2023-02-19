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
//    [Route("api/PatientAPI")]
//    [ApiController]
//    public class PatientAPIController : ControllerBase
//    {
//        protected APIResponse _response;
//        private readonly IMapper _mapper;
//        private readonly IMainRepository _db;

//        public PatientAPIController(IMainRepository db, IMapper mapper)
//        {
//            _db = db;
//            _mapper = mapper;
//            _response = new();
//        }

//        [HttpGet("GetPatients")]
//        [ResponseCache(CacheProfileName = SD.ProfileName)]
//        [Authorize(Roles = SD.SystemManager + "," + SD.HealthFacilityManager)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        public async Task<ActionResult<APIResponse>> GetUsersGetPatients([FromQuery(Name = "searchId")] string id = null, int pageNumber = 1, int pageSize = 0)
//        {
//            try
//            {
//                var entities = await _db._patient.GetAllAsync(
//                    expression: id == null ? null : g => g.Id.ToLower().Contains(id.ToLower()),
//                    pageNumber: pageNumber,
//                    pageSize: pageSize);

//                if (entities.Count == 0)
//                {
//                    return NotFound(APIResponses.NotFound("No data has been found"));
//                }

//                Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };
//                Response.Headers.Add("Pagination", JsonSerializer.Serialize(pagination));

//                _response.Result = _mapper.Map<List<Patient>>(entities);
//                _response.StatusCode = HttpStatusCode.OK;
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }

//        [Authorize(Roles = SD.Patient + "," + SD.Physician + "," + SD.Pharmacist + "," + SD.Nurse + "," + SD.Technician + "," + SD.HealthFacilityManager + "," + SD.SystemManager)]
//        [HttpGet("{id}", Name = "GetPatient")]
//        [ResponseCache(CacheProfileName = SD.ProfileName)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        public async Task<ActionResult<APIResponse>> GetGetPatient(string id)
//        {
//            try
//            {
//                if (id == null)
//                {
//                    return BadRequest(APIResponses.BadRequest("Id is null"));
//                }

//                var entity = await _db._patient.GetAsync(
//                    expression: g => g.Id == id);

//                if (entity == null)
//                {
//                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id} "));
//                }

//                _response.Result = _mapper.Map<PatientDTO>(entity);
//                _response.StatusCode = HttpStatusCode.OK;
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }

//        [Authorize(Roles = SD.Physician + "," + SD.Nurse + "," + SD.HealthFacilityManager)]
//        [HttpPost("CreatePatient")]
//        [ProducesResponseType(StatusCodes.Status201Created)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        public async Task<ActionResult<APIResponse>> CreatePatient([FromBody] PatientCreateDTO entityCreateDTO)
//        {
//            try
//            {
//                if (entityCreateDTO == null)
//                {
//                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
//                }

//                if (await _db._patient.GetAsync(expression: g => g.Id.ToLower() == entityCreateDTO.Id.ToLower()) != null)
//                {
//                    return BadRequest(APIResponses.BadRequest("The object is already exists"));
//                }

//                var entity = _mapper.Map<Patient>(entityCreateDTO);
//                await _db._patient.CreateAsync(entity);

//                _response.Result = _mapper.Map<PatientDTO>(entity);
//                _response.StatusCode = HttpStatusCode.Created;
//                return CreatedAtRoute("GetPatient", new { id = entity.Id }, _response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }

//        [Authorize(Roles = SD.Physician + "," + SD.Nurse + "," + SD.HealthFacilityManager)]
//        [HttpDelete("{id}", Name = "DeletePatient")]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        public async Task<ActionResult<APIResponse>> DeletePatient(string id)
//        {
//            try
//            {
//                if (id == null)
//                {
//                    return BadRequest(APIResponses.BadRequest("Id is null"));
//                }

//                var removedEntity = await _db._patient.GetAsync(expression: g => g.Id == id);
//                if (removedEntity == null)
//                {
//                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
//                }

//                await _db._patient.DeleteAsync(removedEntity);

//                _response.StatusCode = HttpStatusCode.OK;
//                _response.Result = "The object has been deleted";
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }

//        [Authorize(Roles = SD.Physician + "," + SD.Nurse + "," + SD.HealthFacilityManager)]
//        [HttpPut("{id}", Name = "UpdatePatient")]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        public async Task<ActionResult<APIResponse>> UpdatePatient(string id, [FromBody] PatientUpdateDTO entityUpdateDTO)
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

//                if (await _db._patient.GetAsync(expression: g => g.Id == id) == null)
//                {
//                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
//                }

//                var entity = _mapper.Map<Patient>(entityUpdateDTO);
//                entity.UpdateddAt = DateTime.Now;
//                await _db._patient.UpdateAsync(entity);

//                _response.StatusCode = HttpStatusCode.OK;
//                _response.Result = _mapper.Map<PatientDTO>(entity);
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }
//    }
//}
