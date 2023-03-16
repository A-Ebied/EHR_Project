using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.VisitDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/VisitAPI")]
    [ApiController]
    public class VisitAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public VisitAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }


        //[Authorize]
        [HttpGet("GetUserVisits")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetUserVisits(string userId)
        {
            try
            {
                if (userId == null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var entities = await _db._visit.GetAllAsync(
                    expression: g => g.RegistrationDataId == userId);
                if (entities == null || entities.Count == 0)
                {
                    return BadRequest(APIResponses.BadRequest($"No objects with Id = {userId} "));
                }

                _response.Result = _mapper.Map<List<VisitDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpGet("{id}")]
        [ResponseCache(CacheProfileName = SD.ProfileName)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetVisit(int id)
        {
            try
            {
                if (id < 0)
                {
                    return BadRequest(APIResponses.BadRequest("Id is less than 1"));
                }

                var entity = await _db._visit.GetAsync(
                    includeProperties: "VisitVitalSigns,VisitMedications,VisitRadLabTests,PhysicalTherapies,UserVaccinations",
                    expression: g => g.Id == id);

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id} "));
                }

                _response.Result = _mapper.Map<VisitDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpPost("CreateVisit")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> CreateVisit([FromBody] VisitCreateDTO entityCreateDTO)
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

                if (await _db._medicalTeam.GetAsync(expression: e => e.Id == entityCreateDTO.MedicalTeamId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Physician is not exists"));
                }

                if (await _db._healthFacility.GetAsync(expression: e => e.Id == entityCreateDTO.HealthFacilityId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Health Facility is not exists"));
                }

                if (await _db._icd.GetAsync(expression: e => e.Code == entityCreateDTO.ICDId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("ICD is not exists"));
                }

                var entity = _mapper.Map<Visit>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                entity.VisitVitalSigns = null;
                entity.VisitMedications = null;
                entity.VisitRadLabTests = null;
                entity.PhysicalTherapies = null;
                entity.UserVaccinations = null;

                await _db._visit.CreateAsync(entity);
                 
                if (entityCreateDTO.VisitVitalSigns != null)
                {
                    var visitVitalSigns = new List<VisitVitalSign>();
                    var temp = new VisitVitalSign();

                    foreach (var item in entityCreateDTO.VisitVitalSigns)
                    {
                        temp = _mapper.Map<VisitVitalSign>(item);
                        temp.VisitId = entity.Id;
                        temp.CreatedAt = DateTime.Now;
                        temp.UpdatedAt = DateTime.Now;

                        visitVitalSigns.Add(temp);
                    }

                    await _db._visitVital.CreateRangeAsync(visitVitalSigns);
                    entity.VisitVitalSigns = visitVitalSigns;
                }

                if (entityCreateDTO.VisitMedications != null)
                {
                    var visitMedications = new List<VisitMedication>();
                    var temp = new VisitMedication();

                    foreach (var item in entityCreateDTO.VisitMedications)
                    {
                        temp = _mapper.Map<VisitMedication>(item);
                        temp.VisitId = entity.Id;
                        temp.CreatedAt = DateTime.Now;
                        temp.UpdatedAt = DateTime.Now;

                        visitMedications.Add(temp);
                    }

                    await _db._visitMedication.CreateRangeAsync(visitMedications);
                    entity.VisitMedications = visitMedications;
                }

                if (entityCreateDTO.VisitRadLabTests != null)
                {
                    var visitRadLabTests = new List<VisitRadLabTest>();
                    var temp = new VisitRadLabTest();

                    foreach (var item in entityCreateDTO.VisitRadLabTests)
                    {
                        temp = _mapper.Map<VisitRadLabTest>(item);
                        temp.VisitId = entity.Id;
                        temp.CreatedAt = DateTime.Now;
                        temp.UpdatedAt = DateTime.Now;

                        visitRadLabTests.Add(temp);
                    }

                    await _db._visitRadLabTest.CreateRangeAsync(visitRadLabTests);
                    entity.VisitRadLabTests = visitRadLabTests;
                }

                if (entityCreateDTO.PhysicalTherapies != null)
                {
                    var physicalTherapies = new List<PhysicalTherapy>();
                    var temp = new PhysicalTherapy();

                    foreach (var item in entityCreateDTO.PhysicalTherapies)
                    {
                        temp = _mapper.Map<PhysicalTherapy>(item);
                        temp.VisitId = entity.Id;
                        temp.CreatedAt = DateTime.Now;
                        temp.UpdatedAt = DateTime.Now;

                        physicalTherapies.Add(temp);
                    }

                    await _db._physicalTherapy.CreateRangeAsync(physicalTherapies);
                    entity.PhysicalTherapies = physicalTherapies;
                }

                if (entityCreateDTO.UserVaccinations != null)
                {
                    var userVaccinations = new List<UserVaccination>();
                    var temp = new UserVaccination();

                    foreach (var item in entityCreateDTO.UserVaccinations)
                    {
                        temp = _mapper.Map<UserVaccination>(item);
                        temp.VisitId = entity.Id;
                        temp.CreatedAt = DateTime.Now;
                        temp.UpdatedAt = DateTime.Now;

                        userVaccinations.Add(temp);
                    }

                    await _db._userVaccination.CreateRangeAsync(userVaccinations);
                    entity.UserVaccinations = userVaccinations;
                }

                _response.Result = _mapper.Map<VisitDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        //[Authorize]
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> DeleteVisit(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var removedEntity = await _db._visit.GetAsync(expression: g => g.Id == id);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                await _db._visit.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = "The object has been deleted";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        //[Authorize]
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> UpdateVisit(int id, [FromBody] VisitUpdateDTO entityUpdateDTO)
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

                if (await _db._visit.GetAsync(expression: g => g.Id == id) == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                if (await _db._authentication.GetAsync(expression: e => e.Id == entityUpdateDTO.RegistrationDataId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("User is not exists"));
                }

                if (await _db._medicalTeam.GetAsync(expression: e => e.Id == entityUpdateDTO.MedicalTeamId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Physician is not exists"));
                }

                if (await _db._healthFacility.GetAsync(expression: e => e.Id == entityUpdateDTO.HealthFacilityId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Health Facility is not exists"));
                }

                if (await _db._icd.GetAsync(expression: e => e.Code == entityUpdateDTO.ICDId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("ICD is not exists"));
                }

                var entity = _mapper.Map<Visit>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                await _db._visit.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<VisitDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
    }
}
