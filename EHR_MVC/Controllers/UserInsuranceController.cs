using AutoMapper;
using EHR_MVC.DTOs.UserDataDTOs.UserInsuranceDTOS;
using EHR_MVC.Extensions;
using EHR_MVC.Models;
using EHR_MVC.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace EHR_MVC.Controllers
{
    public class UserInsuranceController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUserInsuranceService _service;
        public UserInsuranceController(IMapper mapper, IUserInsuranceService service)
        {
            _mapper = mapper;
            _service = service;
        }
 
        //public async Task<IActionResult> Index()
        //{
        //    List<UserInsuranceDTO> list = new();

        //    var respnse = await _service.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.JWT));
        //    if (respnse != null && respnse.IsSuccess)
        //    {
        //        list = JsonConvert.DeserializeObject<List<UserInsuranceDTO>>(
        //            Convert.ToString(respnse.Result));
        //    }
        //    else
        //    {
        //        if (respnse.Errors.Count > 0)
        //        {
        //            for (int i = 0; i < respnse.Errors.Count; i++)
        //            {
        //                ModelState.AddModelError("Error", respnse.Errors[i]);
        //            }
        //        }
        //    }

        //    return View(list);
        //}
 
        public async Task<IActionResult> MyInsurances(string id)
        {
            List<UserInsuranceDTO> entities = new();
            var respnse = await _service.GetUserInsurancesAsync<APIResponse>(id, HttpContext.Session.GetString(SD.JWT));
            if (respnse != null && respnse.IsSuccess)
            {
                entities = JsonConvert.DeserializeObject<List<UserInsuranceDTO>>(
                    Convert.ToString(respnse.Result));

                return View(entities);
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
            }

            return NotFound(entities);
        }

         public async Task<IActionResult> Create()
         {
            return View();
         }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserInsuranceCreateDTO entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var respnse = await _service.CreateAsync<APIResponse>(entity, HttpContext.Session.GetString(SD.JWT));
                    if (respnse != null && respnse.IsSuccess)
                    {
                        return RedirectToAction(nameof(Index), "Home");
                    }
                    else
                    {
                        if ( respnse != null && respnse.Errors != null )
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

        public async Task<IActionResult> Edit(int id)
        {
            UserInsuranceDTO entity = new();
            var respnse = await _service.GetInsuranceAsync<APIResponse>(id, HttpContext.Session.GetString(SD.JWT));
            if (respnse != null && respnse.IsSuccess)
            {
                entity = JsonConvert.DeserializeObject<UserInsuranceDTO>(
                    Convert.ToString(respnse.Result));

                return View(_mapper.Map<UserInsuranceUpdateDTO>(entity));
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
        public async Task<IActionResult> Edit(int id, UserInsuranceUpdateDTO entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var respnse = await _service.UpdateAsync<APIResponse>(entity, HttpContext.Session.GetString(SD.JWT));
                    if (respnse != null && respnse.IsSuccess)
                    {
                        return RedirectToAction(nameof(Index), "Home");
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
                return View();
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            UserInsuranceDTO entity = new();

            var respnse = await _service.GetInsuranceAsync<APIResponse>(id, HttpContext.Session.GetString(SD.JWT));
            if (respnse != null && respnse.IsSuccess)
            {
                entity = JsonConvert.DeserializeObject<UserInsuranceDTO>(
                    Convert.ToString(respnse.Result));

                return View(_mapper.Map<UserInsuranceDTO>(entity));
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
        public async Task<IActionResult> Delete(UserInsuranceDTO entity)
        {
            try
            {
                var respnse = await _service.DeleteAsync<APIResponse>(entity.Id, HttpContext.Session.GetString(SD.JWT));
                if (respnse != null && respnse.IsSuccess)
                {
                    return RedirectToAction(nameof(Index), "Home");
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

                return View(entity);
            }
            catch
            {
                return View(entity);
            }
        }
    }
}
