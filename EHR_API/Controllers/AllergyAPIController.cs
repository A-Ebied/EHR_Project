using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.AllergyDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/AllergyAPI")]
    [ApiController]
    public class AllergyAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;
       
        public AllergyAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }


        [Authorize]
        [HttpGet("GetUserAllergies")]
        public async Task<ActionResult<APIResponse>> GetUserAllergies(string userId)
        {
            try
            {
                if (userId == null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var entities = new List<Allergy>();

                string jwtToken = null;
                if (HttpContext.Request.Headers.Authorization.Count > 0)
                {
                    jwtToken = HttpContext.Request.Headers.Authorization.ToString().Split(" ")[1];
                }

                string headerRole = null;
                string headerId = null;

                if (jwtToken != null)
                {
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerRole = user.Claims.ToList()[4].Value;
                    headerId = user.Claims.ToList()[0].Value;

                    if (headerId == userId || headerRole == SD.Physician || headerRole == SD.HealthFacilityManager || headerRole == SD.SystemManager)
                    {
                        entities = await _db._allergy.GetAllAsync(expression: g => g.RegistrationDataId == userId);
                    }

                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                if (entities.Count == 0)
                {
                    return BadRequest(APIResponses.BadRequest($"No objects with Id = {userId} "));
                }

                _response.Result = _mapper.Map<List<AllergyDTOForOthers>>(entities);
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
        public async Task<ActionResult<APIResponse>> GetAllergy(int id)
        {
            try
            {
                if (id < 0)
                {
                    return BadRequest(APIResponses.BadRequest("Id is less than 1"));
                }

                var entity = await _db._allergy.GetAsync(
                    includeProperties: "AllergyDrugs",
                    expression: g => g.Id == id);

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id} "));
                }

                if (entity.AllergyDrugs.Count != 0)
                {
                    var temp = new List<AllergyDrug>();
                    foreach (var item in entity.AllergyDrugs)
                    {
                        temp.Add(await _db._allergyDrug.GetAsync(
                                    includeProperties: "Medication",
                                    expression: g => g.Id == item.Id));
                    }

                    entity.AllergyDrugs = temp;
                }

                var response = _mapper.Map<AllergyDTO>(entity);
                response.Drugs = new();
                foreach (var item in entity.AllergyDrugs)
                {
                    if (item.Medication != null)
                    {
                        response.Drugs.Add(new { 
                            id = item.Medication.Id, 
                            name = item.Medication.Name,
                            imageUrl = item.Medication.ImageUrl});
                    }
                    
                }

                _response.Result = response;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize(Roles = SD.HealthFacilityManager + "," + SD.Physician)]
        [HttpPost("CreateAllergy")]
        public async Task<ActionResult<APIResponse>> CreateAllergy([FromBody] AllergyCreateDTO entityCreateDTO)
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

                var entity = _mapper.Map<Allergy>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                entity.AllergyDrugs = null;

                await _db._allergy.CreateAsync(entity);

                if (entityCreateDTO.AllergyDrugs.Count > 0)
                {
                    var allergyDrugs = new List<AllergyDrug>();
                    var temp = new AllergyDrug();

                    foreach (var item in entityCreateDTO.AllergyDrugs)
                    {
                        temp = _mapper.Map<AllergyDrug>(item);
                        temp.AllergyId = entity.Id;
                        temp.CreatedAt = DateTime.Now;
                        temp.UpdatedAt = DateTime.Now;

                        allergyDrugs.Add(temp);
                    }

                    await _db._allergyDrug.CreateRangeAsync(allergyDrugs);
                    entity.AllergyDrugs = allergyDrugs;
                }

                _response.Result = _mapper.Map<AllergyDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        [Authorize(Roles = SD.SystemManager)]
        [HttpDelete("{id}")]
        public async Task<ActionResult<APIResponse>> DeleteAllergy(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var removedEntity = await _db._allergy.GetAsync(expression: g => g.Id == id);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                await _db._allergy.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = "The object has been deleted";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize(Roles = SD.HealthFacilityManager + "," + SD.Physician)]
        [HttpPut("{id}")] 
        public async Task<ActionResult<APIResponse>> UpdateAllergy(int id, [FromBody] AllergyUpdateDTO entityUpdateDTO)
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

                if (await _db._allergy.GetAsync(expression: g => g.Id == id) == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                if (await _db._authentication.GetAsync(expression: e => e.Id == entityUpdateDTO.RegistrationDataId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("User is not exists"));
                }

                var entity = _mapper.Map<Allergy>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                await _db._allergy.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<AllergyDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }
    }
}
