using AutoMapper;
using EHR_API.Entities;
using EHR_API.Entities.DTOs.RadLabResultDTOs;
using EHR_API.Entities.Models;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Net;

namespace EHR_API.Controllers
{
    [Route("api/RadLabResultAPI")]
    [ApiController]
    public class RadLabResultAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IMainRepository _db;
        private readonly IWebHostEnvironment _webHost;
        private readonly IEmailSender _emailSender;

        public RadLabResultAPIController(IMainRepository db, IMapper mapper, IWebHostEnvironment webHost, IEmailSender emailSender)
        {
            _db = db;
            _mapper = mapper;
            _response = new();
            _webHost = webHost;
            _emailSender = emailSender;
        }


        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<APIResponse>> GetRadLabResult(int id)
        {
            try
            {
                if (id < 0)
                {
                    return BadRequest(APIResponses.BadRequest("Id is less than 1"));
                }

                var entity = await _db._radLabResult.GetAsync(
                    includeProperties: "HealthFacility,VisitRadLabTest",
                    expression: g => g.Id == id);

                if (entity == null)
                {
                    return BadRequest(APIResponses.BadRequest($"No object with Id = {id} "));
                }

                var visitRadLabTest = await _db._visitRadLabTest.GetAsync(
                    expression: v => v.Id == entity.VisitRadLabTest.Id,
                    includeProperties: "Visit");

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

                    if (headerId != visitRadLabTest.Visit.RegistrationDataId && headerRole != SD.Physician && headerRole != SD.HealthFacilityManager && headerRole != SD.SystemManager & headerRole != SD.Technician)
                    {
                        return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                    }
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                _response.Result = _mapper.Map<RadLabResultDTO>(entity);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        [HttpPost("CreateRadLabResult")]
        [Authorize(Roles = SD.HealthFacilityManager + "," + SD.Physician + "," + SD.Technician)]
        public async Task<ActionResult<APIResponse>> CreateRadLabResult([FromForm] RadLabResultCreateDTO entityCreateDTO)
        {
            try
            {
                if (entityCreateDTO == null)
                {
                    return BadRequest(APIResponses.BadRequest("No data has been sent"));
                }

                if (await _db._healthFacility.GetAsync(expression: e => e.Id == entityCreateDTO.HealthFacilityId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Health Facility is not exists"));
                }
                
                if (await _db._visitRadLabTest.GetAsync(expression: e => e.Id == entityCreateDTO.VisitRadLabTestId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("RadLab Test Id is not exists"));
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
                }
                else
                {
                    return BadRequest(APIResponses.BadRequest($"Access Denied, you do not have permission to access this data."));
                }

                var entity = _mapper.Map<RadLabResult>(entityCreateDTO);
                entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
                entity.MedicalTeamId = headerId;

                await _db._radLabResult.CreateAsync(entity);

                _response.Result = _mapper.Map<RadLabResultDTO>(entity);
                _response.StatusCode = HttpStatusCode.Created;

                await PneumoniaModelAsync(entity);

                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        [HttpDelete("{id}")]
        [Authorize(Roles = SD.SystemManager)]
        public async Task<ActionResult<APIResponse>> DeleteRadLabResult(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest(APIResponses.BadRequest("Id less than 1"));
                }

                var removedEntity = await _db._radLabResult.GetAsync(expression: g => g.Id == id);
                if (removedEntity == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                await _db._radLabResult.DeleteAsync(removedEntity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = "The object has been deleted";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }


        [HttpPut("{id}")]
        [Authorize(Roles = SD.HealthFacilityManager + "," + SD.Physician + "," + SD.Technician)]
        public async Task<ActionResult<APIResponse>> UpdateRadLabResult(int id, [FromForm] RadLabResultUpdateDTO entityUpdateDTO)
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

                var oldOne = await _db._radLabResult.GetAsync(expression: g => g.Id == id);
                if (oldOne == null)
                {
                    return NotFound(APIResponses.NotFound($"No object with Id = {id} "));
                }

                if (await _db._healthFacility.GetAsync(expression: e => e.Id == entityUpdateDTO.HealthFacilityId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("Health Facility is not exists"));
                }

                if (await _db._visitRadLabTest.GetAsync(expression: e => e.Id == entityUpdateDTO.VisitRadLabTestId) == null)
                {
                    return BadRequest(APIResponses.BadRequest("RadLab Test Id is not exists"));
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

                var entity = _mapper.Map<RadLabResult>(entityUpdateDTO);
                entity.UpdatedAt = DateTime.Now;
                entity.CreatedAt = oldOne.CreatedAt;
                entity.MedicalTeamId = oldOne.MedicalTeamId;

                await _db._radLabResult.UpdateAsync(entity);

                _response.StatusCode = HttpStatusCode.OK;
                _response.Result = _mapper.Map<RadLabResultDTO>(entity);

                await PneumoniaModelAsync(entity);

                return Ok(_response);
            }
            catch (Exception ex)
            {
                return APIResponses.InternalServerError(ex);
            }
        }

        private async Task PneumoniaModelAsync(RadLabResult entity)
        {
            var visitRadLabTest = await _db._visitRadLabTest.GetAsync(
                    expression: r => r.Id == entity.VisitRadLabTestId);

            var visit = await _db._visit.GetAsync(
                expression: r => r.Id == visitRadLabTest.VisitId,
                includeProperties: "RegistrationData");

            var physician = await _db._authentication.GetAsync(
                expression: r => r.Id == visit.MedicalTeamId);

            var temp = visitRadLabTest.TestType.ToLower();
            if (temp.Contains("lung radiology") || temp.Contains("pneumonia")|| temp.Contains("chest x-ray") || temp.Contains("lung x-ray"))
            {
                string is_normal = await SD.MLAPIPneumoniaModelAsync(entity.ImageUrl.ToString());
                if (is_normal.ToLower() == "false")
                {
                    var message = new Message(new string[] { physician.Email }, $"Lung Radiology Result for {visit.RegistrationData.FullName}({visit.RegistrationData.UserName})", "Pneumonia test is positive");

                    await _emailSender.SendEmailAsync(message);
                }
            }
        }
    }
}
