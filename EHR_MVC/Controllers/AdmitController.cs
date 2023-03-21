using AutoMapper;
using EHR_MVC.DTOs.AdmitDTOs;
using EHR_MVC.DTOs.GovernorateDTOs;
using EHR_MVC.DTOs.HealthFacilityDTOs;
using EHR_MVC.DTOs.UserDataDTOs;
using EHR_MVC.Extensions;
using EHR_MVC.Models;
using EHR_MVC.Repositories.Contracts;
using EHR_MVC.VM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace EHR_MVC.Controllers
{
    public class AdmitController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAdmitService _service;
        private readonly IHealthFacilityService _healthFacility;
        private readonly IAuthenService _autService;
        public AdmitController(IMapper mapper, IAdmitService service, IHealthFacilityService healthFacility, IAuthenService authenService)
        {
            _mapper = mapper;
            _service = service;
            _healthFacility = healthFacility;
            _autService = authenService;
        }

        // GET: HealthFacilityController
        //public async Task<IActionResult> Index()
        //{
        //    List<AdmitDTOForOthers> list = new();

        //    var respnse = await _service.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.JWT));
        //    if (respnse != null && respnse.IsSuccess)
        //    {
        //        list = JsonConvert.DeserializeObject<List<HealthFacilityDTOForOthers>>(
        //            Convert.ToString(respnse.Result));
        //    }
        //    else
        //    {
        //        if (respnse != null && respnse.Errors != null)
        //        {
        //            for (int i = 0; i < respnse.Errors.Count; i++)
        //            {
        //                ModelState.AddModelError("Error", respnse.Errors[i]);
        //            }
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("Error", "Unauthorized");
        //        }
        //    }

        //    return View(list);
        //}

        public async Task<IActionResult> Details(int id)
        {
            AdmitDTO entity = new();

            var respnse = await _service.GetAsync<APIResponse>(id, HttpContext.Session.GetString(SD.JWT));
            if (respnse != null && respnse.IsSuccess)
            {
                entity = JsonConvert.DeserializeObject<AdmitDTO>(
                    Convert.ToString(respnse.Result));

                return View(entity);
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

        public async Task<IActionResult> Create()
        {
            AdmitCreateVM admitVM = new();
            var respnse1 = await _healthFacility.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.JWT));
            if (respnse1 != null && respnse1.IsSuccess)
            {
                admitVM.HealthFacilitiesList = JsonConvert.DeserializeObject<List<HealthFacilityDTOForOthers>>(
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

            var respnse2 = await _autService.GetUsersAsync<APIResponse>(HttpContext.Session.GetString(SD.JWT));
            if (respnse2 != null && respnse2.IsSuccess)
            {
                admitVM.UsersList = JsonConvert.DeserializeObject<List<UserDTOForOthers>>(
                    Convert.ToString(respnse2.Result)).Select(i => new SelectListItem()
                    {
                        Text = i.Name + $"({i.UserName})" ,
                        Value = i.Id.ToString()
                    });
            }
            else
            {
                if (respnse2 != null && respnse2.Errors != null)
                {
                    for (int i = 0; i < respnse2.Errors.Count; i++)
                    {
                        ModelState.AddModelError("Error", respnse2.Errors[i]);
                    }
                }
                else
                {
                    ModelState.AddModelError("Error", "Unauthorized");
                }
            }

            return View(admitVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AdmitCreateVM entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var respnse = await _service.CreateAsync<APIResponse>(entity.Admit, HttpContext.Session.GetString(SD.JWT));
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

                var respnse1 = await _healthFacility.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.JWT));
                if (respnse1 != null && respnse1.IsSuccess)
                {
                    entity.HealthFacilitiesList = JsonConvert.DeserializeObject<List<HealthFacilityDTOForOthers>>(
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

                var respnse2 = await _autService.GetUsersAsync<APIResponse>(HttpContext.Session.GetString(SD.JWT));
                if (respnse2 != null && respnse2.IsSuccess)
                {
                    entity.UsersList = JsonConvert.DeserializeObject<List<UserDTOForOthers>>(
                        Convert.ToString(respnse2.Result)).Select(i => new SelectListItem()
                        {
                            Text = i.Name + $"({i.UserName})",
                            Value = i.Id.ToString()
                        });
                }
                else
                {
                    if (respnse2 != null && respnse2.Errors != null)
                    {
                        for (int i = 0; i < respnse2.Errors.Count; i++)
                        {
                            ModelState.AddModelError("Error", respnse2.Errors[i]);
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

        public async Task<IActionResult> Edit(int id)
        {
            AdmitDTO entity = new();

            var respnse = await _service.GetAsync<APIResponse>(id, HttpContext.Session.GetString(SD.JWT));
            if (respnse != null && respnse.IsSuccess)
            {
                entity = JsonConvert.DeserializeObject<AdmitDTO>(
                    Convert.ToString(respnse.Result));

                AdmitUpdateVM admitVM = new();
                var respnse1 = await _healthFacility.GetAllAsync<APIResponse>();
                if (respnse1 != null && respnse1.IsSuccess)
                {
                    admitVM.HealthFacilitiesList = JsonConvert.DeserializeObject<List<HealthFacilityDTOForOthers>>(
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

                var respnse2 = await _autService.GetHealthFacilityManagersAsync<APIResponse>(HttpContext.Session.GetString(SD.JWT));
                if (respnse2 != null && respnse2.IsSuccess)
                {
                    admitVM.UsersList = JsonConvert.DeserializeObject<List<UserDTOForOthers>>(
                        Convert.ToString(respnse2.Result)).Select(i => new SelectListItem()
                        {
                            Text = i.Name + $"({i.UserName})",
                            Value = i.Id.ToString()
                        });
                }
                else
                {
                    if (respnse2 != null && respnse2.Errors != null)
                    {
                        for (int i = 0; i < respnse2.Errors.Count; i++)
                        {
                            ModelState.AddModelError("Error", respnse2.Errors[i]);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("Error", "Unauthorized");
                    }
                }

                admitVM.Admit = _mapper.Map<AdmitUpdateDTO>(entity);
                return View(admitVM);
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

            return NotFound(respnse);
        }

        // POST: HealthFacilityController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AdmitUpdateVM entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var respnse = await _service.UpdateAsync<APIResponse>(entity.Admit, HttpContext.Session.GetString(SD.JWT));
                    if (respnse != null && respnse.IsSuccess)
                    {
                        return RedirectToAction(nameof(Index));
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

                //var respnse1 = await _govService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.JWT));
                //if (respnse1 != null && respnse1.IsSuccess)
                //{
                //    entity.GovernoratesList = JsonConvert.DeserializeObject<List<GovernorateDTOForOthers>>(
                //        Convert.ToString(respnse1.Result)).Select(i => new SelectListItem()
                //        {
                //            Text = i.Title,
                //            Value = i.Id.ToString()
                //        });
                //}
                //else
                //{
                //    if (respnse1 != null && respnse1.Errors != null)
                //    {
                //        for (int i = 0; i < respnse1.Errors.Count; i++)
                //        {
                //            ModelState.AddModelError("Error", respnse1.Errors[i]);
                //        }
                //    }
                //    else
                //    {
                //        ModelState.AddModelError("Error", "Unauthorized");
                //    }
                //}

                //var respnse2 = await _autService.GetHealthFacilityManagersAsync<APIResponse>(HttpContext.Session.GetString(SD.JWT));
                //if (respnse2 != null && respnse2.IsSuccess)
                //{
                //    entity.ManagerList = JsonConvert.DeserializeObject<List<UserDTOForOthers>>(
                //        Convert.ToString(respnse2.Result)).Select(i => new SelectListItem()
                //        {
                //            Text = i.UserName,
                //            Value = i.Id.ToString()
                //        });
                //}
                //else
                //{
                //    if (respnse2 != null && respnse2.Errors != null)
                //    {
                //        for (int i = 0; i < respnse2.Errors.Count; i++)
                //        {
                //            ModelState.AddModelError("Error", respnse2.Errors[i]);
                //        }
                //    }
                //    else
                //    {
                //        ModelState.AddModelError("Error", "Unauthorized");
                //    }
                //}

                return View(entity);
            }
            catch
            {
                return View(entity);
            }
        }

         public async Task<IActionResult> Delete(int id)
        {
            AdmitDTO entity = new();

            var respnse = await _service.GetAsync<APIResponse>(id, HttpContext.Session.GetString(SD.JWT));
            if (respnse != null && respnse.IsSuccess)
            {
                entity = JsonConvert.DeserializeObject<AdmitDTO>(
                    Convert.ToString(respnse.Result));

                return View(_mapper.Map<AdmitDTOForOthers>(entity));
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
        public async Task<IActionResult> Delete(AdmitDTOForOthers entity)
        {
            try
            {
                var respnse = await _service.DeleteAsync<APIResponse>(entity.Id, HttpContext.Session.GetString(SD.JWT));
                if (respnse != null && respnse.IsSuccess)
                {
                    return RedirectToAction(nameof(Index));
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
                return View();
            }
        }
    }
}
