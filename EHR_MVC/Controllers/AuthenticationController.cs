using AutoMapper;
using EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Login;
using EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_MVC.Extensions;
using EHR_MVC.Models;
using EHR_MVC.Repositories.Contracts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.Security.Claims;

namespace EHR_MVC.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAuthenService _service;
        public AuthenticationController(IMapper mapper, IAuthenService service)
        {
            _mapper = mapper;
            _service = service;
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
                        if ( result != null && result.Errors != null )
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
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegistrationDataCreateDTO entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var respnse = await _service.RegisterAsync<APIResponse>(entity);
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
    }
}
