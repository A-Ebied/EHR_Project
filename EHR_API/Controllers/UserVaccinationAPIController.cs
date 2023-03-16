//using AutoMapper;
//using EHR_API.Entities;
//using EHR_API.Entities.DTOs.UserVaccinationDTOs;
//using EHR_API.Entities.Models;
//using EHR_API.Extensions;
//using EHR_API.Repositories.Contracts;
//using Microsoft.AspNetCore.Mvc;
//using System.Net;

//namespace EHR_API.Controllers
//{
//    [Route("api/UserVaccinationAPI")]
//    [ApiController]
//    public class UserVaccinationAPIController : ControllerBase
//    {
//        protected APIResponse _response;
//        private readonly IMapper _mapper;
//        private readonly IMainRepository _db;

//        public UserVaccinationAPIController(IMainRepository db, IMapper mapper)
//        {
//            _db = db;
//            _mapper = mapper;
//            _response = new();
//        }

//        //[Authorize(Roles = SD.SystemManager + "," + SD.HealthFacilityManager)]
//        [HttpPost("CreateUserVaccination")]
//        [ProducesResponseType(StatusCodes.Status201Created)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        public async Task<ActionResult<APIResponse>> CreatePhysicalTherapy([FromBody] UserVaccinationCreateDTO entityCreateDTO)
//        {
//            try
//            {
//                if (entityCreateDTO == null)
//                {
//                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
//                }

//                if (await _db._visit.GetAsync(expression: e => e.Id == entityCreateDTO.VisitId) == null)
//                {
//                    return BadRequest(APIResponses.BadRequest("Visit is not exists"));
//                }
                 
//                //if (await _db._va.GetAsync(expression: e => e.Id == entityCreateDTO.VisitId) == null)
//                //{
//                //    return BadRequest(APIResponses.BadRequest("Visit is not exists"));
//                //}
                 
//                var entity = _mapper.Map<PhysicalTherapy>(entityCreateDTO);
//                entity.CreatedAt = DateTime.Now;
//                entity.UpdatedAt = DateTime.Now;
//                await _db._physicalTherapy.CreateAsync(entity);

//                _response.Result = _mapper.Map<PhysicalTherapyDTOForOthers>(entity);
//                _response.StatusCode = HttpStatusCode.Created;
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }

//        [HttpGet("GetVisitPhysicalTherapies")]
//        [ResponseCache(CacheProfileName = SD.ProfileName)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        public async Task<ActionResult<APIResponse>> GetVisitPhysicalTherapies(int visitId)
//        {
//            try
//            {
//                var entities = await _db._physicalTherapy.GetAllAsync(
//                    expression: visitId == 0 ? null : g => g.VisitId == visitId);

//                if (entities.Count == 0)
//                {
//                    return NotFound(APIResponses.NotFound("No data has been found"));
//                }

//                _response.Result = _mapper.Map<List<PhysicalTherapyDTOForOthers>>(entities);
//                _response.StatusCode = HttpStatusCode.OK;
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }

//        [HttpGet("GetPhysicalTherapy")]
//        [ResponseCache(CacheProfileName = SD.ProfileName)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        public async Task<ActionResult<APIResponse>> GetPhysicalTherapy(int id)
//        {
//            try
//            {
//                if (id < 1)
//                {
//                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
//                }

//                var entity = await _db._physicalTherapy.GetAsync(
//                    expression: g => g.Id == id);

//                if (entity == null)
//                {
//                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id}"));
//                }

//                _response.Result = _mapper.Map<PhysicalTherapyDTO>(entity);
//                _response.StatusCode = HttpStatusCode.OK;
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }

//        //[Authorize(Roles = SD.SystemManager + "," + SD.HealthFacilityManager)]
//        [HttpPut("UpdatePhysicalTherapy")]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        public async Task<ActionResult<APIResponse>> UpdatePhysicalTherapy(int id, [FromBody] PhysicalTherapyUpdateDTO entityUpdateDTO)
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

//                var oldOne = await _db._physicalTherapy.GetAsync(
//                    expression: g => g.Id == id);
//                if (oldOne == null)
//                {
//                    return NotFound(APIResponses.NotFound($"No object with Id = {id}"));
//                }

//                if (await _db._visit.GetAsync(expression: e => e.Id == entityUpdateDTO.VisitId) == null)
//                {
//                    return NotFound(APIResponses.NotFound($"No Visit with Id = {entityUpdateDTO.VisitId}"));
//                }
                 
//                var entity = _mapper.Map<PhysicalTherapy>(entityUpdateDTO);
//                entity.UpdatedAt = DateTime.Now;
//                entity.CreatedAt = oldOne.CreatedAt;
//                await _db._physicalTherapy.UpdateAsync(entity);

//                _response.StatusCode = HttpStatusCode.OK;
//                _response.Result = _mapper.Map<PhysicalTherapyDTO>(entity);
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }

//        //[Authorize(Roles = SD.SystemManager + "," + SD.HealthFacilityManager)]
//        [HttpDelete("DeletePhysicalTherapy")]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        public async Task<ActionResult<APIResponse>> DeletePhysicalTherapy(int id)
//        {
//            try
//            {
//                if (id < 1)
//                {
//                    return BadRequest(APIResponses.BadRequest("Ids less than 1"));
//                }

//                var removedEntity = await _db._physicalTherapy.GetAsync(
//                    expression: g => g.Id == id);
//                if (removedEntity == null)
//                {
//                    return NotFound(APIResponses.NotFound($"No object with Id = {id}"));
//                }

//                await _db._physicalTherapy.DeleteAsync(removedEntity);

//                _response.StatusCode = HttpStatusCode.OK;
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                return APIResponses.InternalServerError(ex);
//            }
//        }
//    }
//}
