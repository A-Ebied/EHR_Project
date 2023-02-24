using AutoMapper;
using EHR_MVC.DTOs.GovernorateDTOs;
using EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Login;
using EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_MVC.DTOs.UserDataDTOs.MedicalDataDTOS;
using EHR_MVC.DTOs.UserDataDTOs.MedicalTeamDTOs;
using EHR_MVC.DTOs.UserDataDTOs.PersonalDataDTOs;
using EHR_MVC.DTOs.UserDataDTOs.RolesDTOs;
using EHR_MVC.Extensions;
using EHR_MVC.Models;
using EHR_MVC.Repositories.Contracts;
using EHR_MVC.VM;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Data;
using System.Security.Claims;

namespace EHR_MVC.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAuthenService _service;
        private readonly IGovernorateService _govService;
        public AuthenticationController(IMapper mapper, IAuthenService service, IGovernorateService govService)
        {
            _mapper = mapper;
            _service = service;
            _govService = govService;
        }

        public async Task<IActionResult> Login()
        {
            LoginRequestDTO entity = new LoginRequestDTO();
            return View(entity);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginRequestDTO entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _service.LoginAsync<APIResponse>(entity);
                    if (result != null && result.IsSuccess)
                    {
                        LoginResponseDTO response = JsonConvert.DeserializeObject<LoginResponseDTO>(
                    Convert.ToString(result.Result));

                        var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                        identity.AddClaim(new Claim("User Id", response.User.Id));
                        identity.AddClaim(new Claim("UserName", response.User.UserName));
                        identity.AddClaim(new Claim("User Email", response.User.Email));
                        foreach (var role in response.Roles)
                        {
                            identity.AddClaim(new Claim(ClaimTypes.Role, role));
                        }

                        var principal = new ClaimsPrincipal(identity);
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                        HttpContext.Session.SetString(SD.JWT, response.Token);
                        return RedirectToAction(nameof(Index), "Home");
                    }
                    else
                    {
                        if (result != null && result.Errors != null)
                        {
                            for (int i = 0; i < result.Errors.Count; i++)
                            {
                                ModelState.AddModelError("Error", result.Errors[i]);
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("Error", "Unauthorized");
                        }
                    }
                }

                return View(entity);
            }
            catch
            {
                return View(entity);
            }
        }

        public async Task<IActionResult> Register()
        {
            RegisterVM register = new();
            var respnse = await _service.GetRolesAsync<APIResponse>(HttpContext.Session.GetString(SD.JWT));
            if (respnse != null && respnse.IsSuccess)
            {

                register.Roles = JsonConvert.DeserializeObject<List<RolesDTO>>(
                    Convert.ToString(respnse.Result)).Select(i => new SelectListItem()
                    {
                        Text = i.Name,
                        Value = i.Name
                    });
            }
            else
            {
                if (respnse != null && respnse.Errors != null)
                {
                    for (int i = 0; i < respnse.Errors.Count; i++)
                    {
                        ModelState.AddModelError("Error", respnse.Errors[i]);
                    }
                }
                else
                {
                    ModelState.AddModelError("Error", "Unauthorized");
                }
            }

            return View(register);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM entity)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var respnse = await _service.RegisterAsync<APIResponse>(entity.Register);
                    if (respnse != null && respnse.IsSuccess)
                    {
                        return RedirectToAction(nameof(Login));
                    }
                    else
                    {
                        if (respnse != null && respnse.Errors != null)
                        {
                            for (int i = 0; i < respnse.Errors.Count; i++)
                            {
                                ModelState.AddModelError("Error", respnse.Errors[i]);
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("Error", "Unauthorized");
                        }
                    }
                }

                var respnse1 = await _service.GetRolesAsync<APIResponse>(HttpContext.Session.GetString(SD.JWT));
                if (respnse1 != null && respnse1.IsSuccess)
                {

                    entity.Roles = JsonConvert.DeserializeObject<List<RolesDTO>>(
                        Convert.ToString(respnse1.Result)).Select(i => new SelectListItem()
                        {
                            Text = i.Name,
                            Value = i.Name
                        });
                }
                else
                {
                    if (respnse1 != null && respnse1.Errors != null)
                    {
                        for (int i = 0; i < respnse1.Errors.Count; i++)
                        {
                            ModelState.AddModelError("Error", respnse1.Errors[i]);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("Error", "Unauthorized");
                    }
                }

                return View(entity);
            }
            catch
            {
                return View(entity);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.SetString(SD.JWT, "");
            return RedirectToAction(nameof(Index), "Home");
        }

        public async Task<IActionResult> AccessDenied()
        {
            return View();
        }

        public async Task<IActionResult> UserData(string id)
        {

            RegistrationDataDTO userData = new();
            var respnse = await _service.GetUserAsync<APIResponse>(id, HttpContext.Session.GetString(SD.JWT));
            if (respnse != null && respnse.IsSuccess)
            {

                userData = JsonConvert.DeserializeObject<RegistrationDataDTO>(Convert.ToString(respnse.Result));
            }
            else
            {
                if (respnse != null && respnse.Errors != null)
                {
                    for (int i = 0; i < respnse.Errors.Count; i++)
                    {
                        ModelState.AddModelError("Error", respnse.Errors[i]);
                    }
                }
                else
                {
                    ModelState.AddModelError("Error", "Error");
                }
            }

            return View(userData);
        }
        
        public async Task<IActionResult> CreateUserPersonalData()
        {
            PersonalDataVM personalData = new();
            var respnse = await _govService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.JWT));
            if (respnse != null && respnse.IsSuccess)
            {
                personalData.GovernoratesList = JsonConvert.DeserializeObject<List<GovernorateDTOForOthers>>(
                    Convert.ToString(respnse.Result)).Select(i => new SelectListItem()
                    {
                        Text = i.Title,
                        Value = i.Id.ToString()
                    });
            }
            else
            {
                if (respnse != null && respnse.Errors != null)
                {
                    for (int i = 0; i < respnse.Errors.Count; i++)
                    {
                        ModelState.AddModelError("Error", respnse.Errors[i]);
                    }
                }
                else
                {
                    ModelState.AddModelError("Error", "Unauthorized");
                }
            }

            return View(personalData);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUserPersonalData(PersonalDataVM entity, IFormFile image)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (image != null)
                    {
                        using (var ms = new MemoryStream())
                        {
                            image.CopyTo(ms);
                            var fileBytes = ms.ToArray();
                           
                            entity.PersonalData.UserImage = fileBytes;
                            entity.PersonalData.ImageName = image.FileName;
                        }
                    }

                    var respnse = await _service.CreateUserPersonalDataAsync<APIResponse>(entity.PersonalData, HttpContext.Session.GetString(SD.JWT));
                    if (respnse != null && respnse.IsSuccess)
                    {
                        return RedirectToAction(nameof(UserData), new { id = entity.PersonalData.Id });
                    }
                    else
                    {
                        if (respnse != null && respnse.Errors != null)
                        {
                            for (int i = 0; i < respnse.Errors.Count; i++)
                            {
                                ModelState.AddModelError("Error", respnse.Errors[i]);
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("Error", "The user has data");
                        }
                    }
                }

                PersonalDataVM personalData = new();
                var respnse1 = await _govService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.JWT));
                if (respnse1 != null && respnse1.IsSuccess)
                {
                    personalData.GovernoratesList = JsonConvert.DeserializeObject<List<GovernorateDTOForOthers>>(
                        Convert.ToString(respnse1.Result)).Select(i => new SelectListItem()
                        {
                            Text = i.Title,
                            Value = i.Id.ToString()
                        });
                }
                else
                {
                    if (respnse1 != null && respnse1.Errors != null)
                    {
                        for (int i = 0; i < respnse1.Errors.Count; i++)
                        {
                            ModelState.AddModelError("Error", respnse1.Errors[i]);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("Error", "Unauthorized");
                    }
                }

                return View(entity);
            }
            catch
            {
                return View(entity);
            }
        }

        public async Task<IActionResult> DeletePersonalData(string id)
        {
            RegistrationDataDTO entity = new();

            var respnse = await _service.GetUserAsync<APIResponse>(id, HttpContext.Session.GetString(SD.JWT));
            if (respnse != null && respnse.IsSuccess)
            {
                entity = JsonConvert.DeserializeObject<RegistrationDataDTO>(
                    Convert.ToString(respnse.Result));

                return View(_mapper.Map<PersonalDataDTOForOthers>(entity.PersonalData));
            }
            else
            {
                if (respnse != null && respnse.Errors != null)
                {
                    for (int i = 0; i < respnse.Errors.Count; i++)
                    {
                        ModelState.AddModelError("Error", respnse.Errors[i]);
                    }
                }
                else
                {
                    ModelState.AddModelError("Error", "Unauthorized");
                }
            }

            return NotFound(entity);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePersonalData(PersonalDataDTOForOthers entity)
        {
            try
            {
                var respnse = await _service.DeleteUserPersonalDataAsync<APIResponse>(entity.Id, HttpContext.Session.GetString(SD.JWT));
                if (respnse != null && respnse.IsSuccess)
                {
                    return RedirectToAction(nameof(UserData), new { id = entity.Id });
                }
                else
                {
                    if (respnse != null && respnse.Errors != null)
                    {
                        for (int i = 0; i < respnse.Errors.Count; i++)
                        {
                            ModelState.AddModelError("Error", respnse.Errors[i]);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("Error", "Error");
                    }
                }

                return View(entity);
            }
            catch
            {
                return View(entity);
            }
        }

        public async Task<IActionResult> UpdatePersonalData(string id)
        {
            RegistrationDataDTO entity = new();
            var respnse = await _service.GetUserAsync<APIResponse>(id, HttpContext.Session.GetString(SD.JWT));
            if (respnse != null && respnse.IsSuccess)
            {
                entity = JsonConvert.DeserializeObject<RegistrationDataDTO>(
                    Convert.ToString(respnse.Result));

                return View(_mapper.Map<PersonalDataUpdateDTO>(entity.PersonalData));
            }
            else
            {
                if (respnse != null && respnse.Errors != null)
                {
                    for (int i = 0; i < respnse.Errors.Count; i++)
                    {
                        ModelState.AddModelError("Error", respnse.Errors[i]);
                    }
                }
                else
                {
                    ModelState.AddModelError("Error", "Unauthorized");
                }
            }

            return NotFound();
        }
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdatePersonalData(string id, PersonalDataUpdateDTO entity, IFormFile image)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (image != null)
                    {
                        using (var ms = new MemoryStream())
                        {
                            image.CopyTo(ms);
                            var fileBytes = ms.ToArray();

                            entity.UserImage = fileBytes;
                            entity.ImageName = image.FileName;
                        }
                    }

                    var respnse = await _service.UpdateUserPersonalDataAsync<APIResponse>(id, entity, HttpContext.Session.GetString(SD.JWT));
                    if (respnse != null && respnse.IsSuccess)
                    {
                        return RedirectToAction(nameof(UserData), new { id = entity.Id });
                    }
                    else
                    {
                        if (respnse != null && respnse.Errors != null)
                        {
                            for (int i = 0; i < respnse.Errors.Count; i++)
                            {
                                ModelState.AddModelError("Error", respnse.Errors[i]);
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("Error", "Error");
                        }
                    }
                }

                return View(entity);
            }
            catch
            {
                return View();
            }
        } 
        
        public async Task<IActionResult> CreateUserMedicalData()
        {
             return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUserMedicalData(MedicalDataCreateDTO entity, IFormFile image)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (image != null)
                    {
                        using (var ms = new MemoryStream())
                        {
                            image.CopyTo(ms);
                            var fileBytes = ms.ToArray();
                           
                            entity.DNAImageResult = fileBytes;
                            entity.ImageName = image.FileName;
                        }
                    }

                    var respnse = await _service.CreateUserMedicalDataAsync<APIResponse>(entity, HttpContext.Session.GetString(SD.JWT));

                    if (respnse != null && respnse.IsSuccess)
                    {
                        return RedirectToAction(nameof(UserData), new { id = entity.Id });
                    }
                    else
                    {
                        if (respnse != null && respnse.Errors != null)
                        {
                            for (int i = 0; i < respnse.Errors.Count; i++)
                            {
                                ModelState.AddModelError("Error", respnse.Errors[i]);
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("Error", "The user has data");
                        }
                    }
                }

                return View(entity);
            }
            catch
            {
                return View(entity);
            }
        }

        public async Task<IActionResult> DeleteMedicalData(string id)
        {
            RegistrationDataDTO entity = new();

            var respnse = await _service.GetUserAsync<APIResponse>(id, HttpContext.Session.GetString(SD.JWT));
            if (respnse != null && respnse.IsSuccess)
            {
                entity = JsonConvert.DeserializeObject<RegistrationDataDTO>(
                    Convert.ToString(respnse.Result));

                return View(_mapper.Map<MedicalDataDTOForOthers>(entity.MedicalData));
            }
            else
            {
                if (respnse != null && respnse.Errors != null)
                {
                    for (int i = 0; i < respnse.Errors.Count; i++)
                    {
                        ModelState.AddModelError("Error", respnse.Errors[i]);
                    }
                }
                else
                {
                    ModelState.AddModelError("Error", "Error");
                }
            }

            return NotFound(entity);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteMedicalData(MedicalDataDTOForOthers entity)
        {
            try
            {
                var respnse = await _service.DeleteUserMedicalDataAsync<APIResponse>(entity.Id, HttpContext.Session.GetString(SD.JWT));
                if (respnse != null && respnse.IsSuccess)
                {
                    return RedirectToAction(nameof(UserData), new { id = entity.Id });
                }
                else
                {
                    if (respnse != null && respnse.Errors != null)
                    {
                        for (int i = 0; i < respnse.Errors.Count; i++)
                        {
                            ModelState.AddModelError("Error", respnse.Errors[i]);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("Error", "Error");
                    }
                }

                return View(entity);
            }
            catch
            {
                return View(entity);
            }
        }

        public async Task<IActionResult> UpdateMedicalData(string id)
        {
            RegistrationDataDTO entity = new();
            var respnse = await _service.GetUserAsync<APIResponse>(id, HttpContext.Session.GetString(SD.JWT));
            if (respnse != null && respnse.IsSuccess)
            {
                entity = JsonConvert.DeserializeObject<RegistrationDataDTO>(
                    Convert.ToString(respnse.Result));

                return View(_mapper.Map<MedicalDataUpdateDTO>(entity.MedicalData));
            }
            else
            {
                if (respnse != null && respnse.Errors != null)
                {
                    for (int i = 0; i < respnse.Errors.Count; i++)
                    {
                        ModelState.AddModelError("Error", respnse.Errors[i]);
                    }
                }
                else
                {
                    ModelState.AddModelError("Error", "Unauthorized");
                }
            }

            return NotFound();
        }
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateMedicalData(string id, MedicalDataUpdateDTO entity, IFormFile image)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (image != null)
                    {
                        using (var ms = new MemoryStream())
                        {
                            image.CopyTo(ms);
                            var fileBytes = ms.ToArray();

                            entity.DNAImageResult = fileBytes;
                            entity.ImageName = image.FileName;
                        }
                    }

                    var respnse = await _service.UpdateUserMedicalDataAsync<APIResponse>(id, entity, HttpContext.Session.GetString(SD.JWT));
                    if (respnse != null && respnse.IsSuccess)
                    {
                        return RedirectToAction(nameof(UserData), new { id = entity.Id });
                    }
                    else
                    {
                        if (respnse != null && respnse.Errors != null)
                        {
                            for (int i = 0; i < respnse.Errors.Count; i++)
                            {
                                ModelState.AddModelError("Error", respnse.Errors[i]);
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("Error", "Error");
                        }
                    }
                }

                return View(entity);
            }
            catch
            {
                return View();
            }
        }
    }
}
