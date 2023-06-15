using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.ChronicDiseaseDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/ChronicDiseaseAPI")]
    [ApiController]
    public class ChronicDiseaseAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;

        public ChronicDiseaseAPIController(IMainRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
        }

        [Authorize]
        [HttpGet("GetUserChronicDiseases")]
        public async Task<ActionResult<APIResponse>> GetUserChronicDiseases(string userId)
        {
            try
            {
                if (userId == null)
                {
                    return BadRequest(APIResponses.BadRequest("Id is null"));
                }

                var entities = await _db._chronicDisease.GetAllAsync(
                    includeProperties: "ICD",
                    expression: g => g.RegistrationDataId == userId);
                
                if (entities.Count == 0)
                {
                    return BadRequest(APIResponses.BadRequest($"No objects with Id = {userId} "));
                }
                
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

                    if (headerId != userId && headerRole != SD.Physician && headerRole != SD.HealthFacilityManager && headerRole != SD.SystemManager)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }



                _response.Result = _mapper.Map<List<ChronicDiseaseDTOForOthers>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<APIResponse>> GetChronicDisease(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id is < 1"));
                }

                var entity = await _db._chronicDisease.GetAsync(
                     includeProperties: "ICD,ChronicDiseaseDrugs",
                     expression: g => g.Id == id);

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id}"));
                }

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

                    if (headerId != entity.RegistrationDataId && headerRole != SD.Physician && headerRole != SD.HealthFacilityManager && headerRole != SD.SystemManager)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                if (entity.ChronicDiseaseDrugs.Count != 0)
                {
                    var temp = new List<ChronicDiseaseDrug>();
                    foreach (var item in entity.ChronicDiseaseDrugs)
                    {
                        temp.Add(await _db._chronicDiseaseDrug.GetAsync(
                                    includeProperties: "Medication",
                                    expression: g => g.Id == item.Id));
                    }

                    entity.ChronicDiseaseDrugs = temp;
                }

                _response.Result = _mapper.Map<ChronicDiseaseDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        [HttpPost("CreateChronicDisease")]
        [Authorize(Roles = SD.HealthFacilityManager + "," + SD.Physician)]
        public async Task<ActionResult<APIResponse>> CreateChronicDisease([FromBody] ChronicDiseaseCreateDTO entityCreateDTO)
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

                if (await _db._icd.GetAsync(expression: e => e.Code == entityCreateDTO.ICDId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("ICD is not exists"));
                }

                var entity = _mapper.Map<ChronicDisease>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                entity.ChronicDiseaseDrugs = null;

                string jwtToken = null;
                if (HttpContext.Request.Headers.Authorization.Count > 0)
                {
                    jwtToken = HttpContext.Request.Headers.Authorization.ToString().Split(" ")[1];
                }

                string headerId = null;

                if (jwtToken != null)
                {
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerId = user.Claims.ToList()[0].Value;

                    entity.MedicalTeamId = headerId;
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                await _db._chronicDisease.CreateAsync(entity);

                if (entityCreateDTO.ChronicDiseaseDrugs.Count > 0)
                {
                    var chronicDiseaseDrugs = new List<ChronicDiseaseDrug>();
                    var temp = new ChronicDiseaseDrug();

                    foreach (var item in entityCreateDTO.ChronicDiseaseDrugs)
                    {
                        temp = _mapper.Map<ChronicDiseaseDrug>(item);
                        temp.ChronicDiseaseId = entity.Id;
                        temp.CreatedAt = DateTime.Now;
                        temp.UpdatedAt = DateTime.Now;

                        chronicDiseaseDrugs.Add(temp);
                    }

                    await _db._chronicDiseaseDrug.CreateRangeAsync(chronicDiseaseDrugs);
                    entity.ChronicDiseaseDrugs = chronicDiseaseDrugs;
                }

                _response.Result = _mapper.Map<ChronicDiseaseDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        //[HttpDelete("{id}")]
        //[Authorize(Roles = SD.HealthFacilityManager + "," + SD.Physician)]
        //public async Task<ActionResult<APIResponse>> DeleteChronicDisease(int id)
        //{
        //    try
        //    {
        //        if (id < 1)
        //        {
        //            return BadRequest(APIResponses.BadRequest("Id is < 1"));
        //        }

        //        var removedEntity = await _db._chronicDisease.GetAsync(expression: g => g.Id == id);
        //        if (removedEntity == null)
        //        {
        //            return NotFound(APIResponses.NotFound($"No object with Id = {id}"));
        //        }

        //        string jwtToken = null;
        //        if (HttpContext.Request.Headers.Authorization.Count > 0)
        //        {
        //            jwtToken = HttpContext.Request.Headers.Authorization.ToString().Split(" ")[1];
        //        }

        //        string headerId = null;
        //        if (jwtToken != null)
        //        {
        //            var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
        //            headerId = user.Claims.ToList()[0].Value;

        //            if (headerId != removedEntity.MedicalTeamId)
        //            {
        //                return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
        //            }
        //        }
        //        else
        //        {
        //            return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
        //        }

        //        await _db._chronicDisease.DeleteAsync(removedEntity);

        //        _response.StatusCode = HttpStatusCode.OK;
        //        _response.Result = "The object has been deleted";
        //        return Ok(_response);
        //    }
        //    catch (Exception ex)
        //    {
        //        return APIResponses.InternalServerError(ex);
        //    }
        //}


        [HttpPut("{id}")]
        [Authorize(Roles = SD.HealthFacilityManager + "," + SD.Physician)]
        public async Task<ActionResult<APIResponse>> UpdateChronicDisease(int id, [FromBody] ChronicDiseaseUpdateDTO entityUpdateDTO)
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

                var oldOne = await _db._chronicDisease.GetAsync(expression: g => g.Id == id);
                if (oldOne == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id}"));
                }

                string jwtToken = null;
                if (HttpContext.Request.Headers.Authorization.Count > 0)
                {
                    jwtToken = HttpContext.Request.Headers.Authorization.ToString().Split(" ")[1];
                }

                string headerId = null;

                if (jwtToken != null)
                {
                    var user = new JwtSecurityTokenHandler().ReadJwtToken(jwtToken);
                    headerId = user.Claims.ToList()[0].Value;

                    if (headerId != oldOne.MedicalTeamId)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                if (await _db._authentication.GetAsync(expression: e => e.Id == entityUpdateDTO.RegistrationDataId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("User is not exists"));
                }

                if (await _db._icd.GetAsync(expression: e => e.Code == entityUpdateDTO.ICDId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("ICD is not exists"));
                }

                var entity = _mapper.Map<ChronicDisease>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                entity.CreatedAt = oldOne.CreatedAt;
                await _db._chronicDisease.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<ChronicDiseaseDTO>(entity);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);

            }
        }
    }
}
