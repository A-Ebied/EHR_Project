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
//    [Route("api/InsuranceDataAPI")]
//    [ApiController]
//    public class InsuranceDataAPIController : ControllerBase
//    {
//        protected APIResponse _response;
//        private readonly IMapper _mapper;
//        private readonly IMainRepository _db;

//        public InsuranceDataAPIController(IMainRepository db, IMapper mapper)
//        {
//            _db = db;
//            _mapper = mapper;
//            _response = new();
//        }

//        [Authorize(Roles = SD.SystemManager)]
//        [HttpGet("GetUsersInsuranceData")]
//        [ResponseCache(CacheProfileName = SD.ProfileName)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        public async Task<ActionResult<APIResponse>> GetUsersInsuranceData([FromQuery(Name = "hasGovernmentInsurance")] string govInsurance = null, [FromQuery(Name = "hasAnotherInsurance")] string anotherInsurance = null, int pageNumber = 1, int pageSize = 0)
//        {
//            try
//            {
//                IEnumerable<InsuranceData> entities = await _db._insuranceData.GetAllAsync(
//                   includeProperties: "UserInsurances",
//                   pageNumber: pageNumber,
//                   pageSize: pageSize);

//                if (govInsurance.ToLower() == "true")
//                {
//                    entities = entities.Where(g => g.HasGovernmentInsurance == true);
//                }
//                else if (govInsurance.ToLower() == "false")
//                {
//                    entities = entities.Where(g => g.HasGovernmentInsurance == false);
//                }

//                if (anotherInsurance.ToLower() == "true")
//                {
//                    entities = entities.Where(g => g.HasAnotherInsurance == true);
//                }
//                else if (anotherInsurance.ToLower() == "false")
//                {
//                    entities = entities.Where(g => g.HasAnotherInsurance == false);
//                }

//                if (entities.ToList().Count == 0)
//                {
//                    return NotFound(APIResponses.NotFound("No data has been found"));
//                }

//                Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };
//                Response.Headers.Add("Pagination", JsonSerializer.Serialize(pagination));

//                _response.Result = _mapper.Map<List<InsuranceData>>(entities);
//                _response.StatusCode = HttpStatusCode.OK;
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }

//        [Authorize(Roles = SD.Patient + "," + SD.Physician + "," + SD.Pharmacist + "," + SD.Nurse + "," + SD.Technician + "," + SD.HealthFacilityManager)]
//        [HttpGet("{id}", Name = "GetUserInsuranceData")]
//        [ResponseCache(CacheProfileName = SD.ProfileName)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        public async Task<ActionResult<APIResponse>> GetUserInsuranceData(string id)
//        {
//            try
//            {
//                if (id == null)
//                {
//                    return BadRequest(APIResponses.BadRequest("Id is null"));
//                }

//                var entity = await _db._insuranceData.GetAsync(
//                     includeProperties: "UserInsurances",
//                    expression: g => g.Id == id);

//                if (entity == null)
//                {
//                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id} "));
//                }

//                _response.Result = _mapper.Map<InsuranceDataDTO>(entity);
//                _response.StatusCode = HttpStatusCode.OK;
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }

//        [Authorize(Roles = SD.Physician + "," + SD.Pharmacist + "," + SD.Nurse + "," + SD.Technician + "," + SD.HealthFacilityManager)]
//        [HttpPost("CreateUserInsuranceData")]
//        [ProducesResponseType(StatusCodes.Status201Created)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        public async Task<ActionResult<APIResponse>> CreateUserInsuranceData([FromBody] InsuranceDataCreateDTO entityCreateDTO)
//        {
//            try
//            {
//                if (entityCreateDTO == null)
//                {
//                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
//                }

//                if (await _db._insuranceData.GetAsync(expression: g => g.Id.ToLower() == entityCreateDTO.Id.ToLower()) != null)
//                {
//                    return BadRequest(APIResponses.BadRequest("The object is already exists"));
//                }

//                var entity = _mapper.Map<InsuranceData>(entityCreateDTO);
//                entity.CreatedAt = DateTime.Now;
//                entity.UpdateddAt = DateTime.Now;
//                await _db._insuranceData.CreateAsync(entity);
//                if (entityCreateDTO.UserInsurancesCreateDTO != null)
//                {
//                    await _db._userInsurance.CreateRangeAsync(
//                        _mapper.Map<List<UserInsurance>>(entityCreateDTO.UserInsurancesCreateDTO._userInsurances.ToList()));
//                }

//                _response.Result = _mapper.Map<InsuranceDataDTO>(entity);
//                _response.StatusCode = HttpStatusCode.Created;
//                return CreatedAtRoute("GetUserInsuranceData", new { id = entity.Id }, _response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }

//        [Authorize(Roles = SD.Physician + "," + SD.Pharmacist + "," + SD.Nurse + "," + SD.Technician + "," + SD.HealthFacilityManager)]
//        [HttpPost("CreateUserInsuranceData")]
//        [HttpDelete("{id}", Name = "DeleteInsuranceData")]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        public async Task<ActionResult<APIResponse>> DeleteInsuranceData(string id)
//        {
//            try
//            {
//                if (id == null)
//                {
//                    return BadRequest(APIResponses.BadRequest("Id is null"));
//                }

//                var removedEntity = await _db._insuranceData.GetAsync(expression: g => g.Id == id);
//                if (removedEntity == null)
//                {
//                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
//                }

//                await _db._insuranceData.DeleteAsync(removedEntity);

//                _response.StatusCode = HttpStatusCode.OK;
//                _response.Result = "The object has been deleted";
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }

//        [Authorize(Roles = SD.Physician + "," + SD.Pharmacist + "," + SD.Nurse + "," + SD.Technician + "," + SD.HealthFacilityManager)]
//        [HttpPost("CreateUserInsuranceData")]
//        [HttpPut("{id}", Name = "UpdateUserInsuranceData")]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        public async Task<ActionResult<APIResponse>> UpdateUserInsuranceData(string id, [FromBody] InsuranceDataUpdateDTO entityUpdateDTO)
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

//                if (await _db._insuranceData.GetAsync(expression: g => g.Id == id) == null)
//                {
//                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
//                }

//                var entity = _mapper.Map<InsuranceData>(entityUpdateDTO);
//                entity.UpdateddAt = DateTime.Now;
//                await _db._insuranceData.UpdateAsync(entity);

//                _response.StatusCode = HttpStatusCode.OK;
//                _response.Result = _mapper.Map<InsuranceDataDTO>(entity);
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }
//    }
//}
