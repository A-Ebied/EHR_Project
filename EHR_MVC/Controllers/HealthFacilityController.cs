using AutoMapper;
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
    public class HealthFacilityController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IHealthFacilityService _service;
        private readonly IGovernorateService _govService;
        private readonly IAuthenService _autService;
        public HealthFacilityController(IMapper mapper, IHealthFacilityService service, IGovernorateService govService, IAuthenService authenService)
        {
            _mapper = mapper;
            _service = service;
            _govService = govService;
            _autService = authenService;
        }

        // GET: HealthFacilityController
        public async Task<IActionResult> Index()
        {
            List<HealthFacilityDTOForOthers> list = new();

            var respnse = await _service.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.JWT));
            if (respnse != null && respnse.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<HealthFacilityDTOForOthers>>(
                    Convert.ToString(respnse.Result));
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

            return View(list);
        }

        // GET: HealthFacilityController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            HealthFacilityDTO entity = new();

            var respnse = await _service.GetAsync<APIResponse>(id, HttpContext.Session.GetString(SD.JWT));
            if (respnse != null && respnse.IsSuccess)
            {
                entity = JsonConvert.DeserializeObject<HealthFacilityDTO>(
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

        // GET: HealthFacilityController/Create
        public async Task<IActionResult> Create()
        {
            HealthFacilityCreateVM healthFacility = new();
            var respnse1 = await _govService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.JWT));
            if (respnse1 != null && respnse1.IsSuccess)
            {
                healthFacility.GovernoratesList = JsonConvert.DeserializeObject<List<GovernorateDTOForOthers>>(
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
                healthFacility.ManagerList = JsonConvert.DeserializeObject<List<UserDTOForOthers>>(
                    Convert.ToString(respnse2.Result)).Select(i => new SelectListItem()
                    {
                        Text = i.UserName,
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

            return View(healthFacility);
        }

        // POST: HealthFacilityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HealthFacilityCreateVM entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var respnse = await _service.CreateAsync<APIResponse>(entity.HealthFacility, HttpContext.Session.GetString(SD.JWT));
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

                var respnse1 = await _govService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.JWT));
                if (respnse1 != null && respnse1.IsSuccess)
                {
                    entity.GovernoratesList = JsonConvert.DeserializeObject<List<GovernorateDTOForOthers>>(
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
                    entity.ManagerList = JsonConvert.DeserializeObject<List<UserDTOForOthers>>(
                        Convert.ToString(respnse2.Result)).Select(i => new SelectListItem()
                        {
                            Text = i.UserName,
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

        // GET: HealthFacilityController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            HealthFacilityDTO entity = new();

            var respnse = await _service.GetAsync<APIResponse>(id, HttpContext.Session.GetString(SD.JWT));
            if (respnse != null && respnse.IsSuccess)
            {
                entity = JsonConvert.DeserializeObject<HealthFacilityDTO>(
                    Convert.ToString(respnse.Result));

                HealthFacilityUpdateVM healthFacility = new();
                var respnse1 = await _govService.GetAllAsync<APIResponse>();
                if (respnse1 != null && respnse1.IsSuccess)
                {
                    healthFacility.GovernoratesList = JsonConvert.DeserializeObject<List<GovernorateDTOForOthers>>(
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
                    healthFacility.ManagerList = JsonConvert.DeserializeObject<List<UserDTOForOthers>>(
                        Convert.ToString(respnse2.Result)).Select(i => new SelectListItem()
                        {
                            Text = i.UserName,
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

                healthFacility.HealthFacility = _mapper.Map<HealthFacilityUpdateDTO>(entity);
                return View(healthFacility);
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
        public async Task<IActionResult> Edit(int id, HealthFacilityUpdateVM entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var respnse = await _service.UpdateAsync<APIResponse>(entity.HealthFacility, HttpContext.Session.GetString(SD.JWT));
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

                var respnse1 = await _govService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.JWT));
                if (respnse1 != null && respnse1.IsSuccess)
                {
                    entity.GovernoratesList = JsonConvert.DeserializeObject<List<GovernorateDTOForOthers>>(
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
                    entity.ManagerList = JsonConvert.DeserializeObject<List<UserDTOForOthers>>(
                        Convert.ToString(respnse2.Result)).Select(i => new SelectListItem()
                        {
                            Text = i.UserName,
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

        // GET: HealthFacilityController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            HealthFacilityDTO entity = new();

            var respnse = await _service.GetAsync<APIResponse>(id, HttpContext.Session.GetString(SD.JWT));
            if (respnse != null && respnse.IsSuccess)
            {
                entity = JsonConvert.DeserializeObject<HealthFacilityDTO>(
                    Convert.ToString(respnse.Result));

                return View(_mapper.Map<HealthFacilityDTOForOthers>(entity));
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

        // POST: HealthFacilityController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(HealthFacilityDTOForOthers entity)
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
