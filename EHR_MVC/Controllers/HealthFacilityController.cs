using AutoMapper;
using EHR_MVC.DTOs.HealthFacilityDTOs;
using EHR_MVC.Models;
using EHR_MVC.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EHR_MVC.Controllers
{
    public class HealthFacilityController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IHealthFacilityService _service;
        public HealthFacilityController(IMapper mapper, IHealthFacilityService service)
        {
            _mapper = mapper;
            _service = service;
        }

        // GET: HealthFacilityController
        public async Task<IActionResult> Index()
        {
            List<HealthFacilityDTOForOthers> list = new();

            var respnse = await _service.GetAllAsync<APIResponse>();
            if (respnse != null && respnse.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<HealthFacilityDTOForOthers>>(
                    Convert.ToString(respnse.Result));
            }

            return View(list);
        }

        // GET: HealthFacilityController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            HealthFacilityDTO entity = new();

            var respnse = await _service.GetAsync<APIResponse>(id);
            if (respnse != null && respnse.IsSuccess)
            {
                entity = JsonConvert.DeserializeObject<HealthFacilityDTO>(
                    Convert.ToString(respnse.Result));

                return View(entity);
            }

            return NotFound(entity);
        }

        // GET: HealthFacilityController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: HealthFacilityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HealthFacilityCreateDTO entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var respnse = await _service.CreateAsync<APIResponse>(entity);
                    if (respnse != null && respnse.IsSuccess)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }

                return View(entity);
            }
            catch
            {
                return View();
            }
        }

        // GET: HealthFacilityController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            HealthFacilityDTO entity = new();

            var respnse = await _service.GetAsync<APIResponse>(id);
            if (respnse != null && respnse.IsSuccess)
            {
                entity = JsonConvert.DeserializeObject<HealthFacilityDTO>(
                    Convert.ToString(respnse.Result));

                return View(_mapper.Map<HealthFacilityUpdateDTO>(entity));
            }

            return NotFound();
        }

        // POST: HealthFacilityController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, HealthFacilityUpdateDTO entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var respnse = await _service.UpdateAsync<APIResponse>(entity);
                    if (respnse != null && respnse.IsSuccess)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }

                return View(entity);
            }
            catch
            {
                return View();
            }
        }

        // GET: HealthFacilityController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            HealthFacilityDTO entity = new();

            var respnse = await _service.GetAsync<APIResponse>(id);
            if (respnse != null && respnse.IsSuccess)
            {
                entity = JsonConvert.DeserializeObject<HealthFacilityDTO>(
                    Convert.ToString(respnse.Result));

                return View(_mapper.Map<HealthFacilityDTOForOthers>(entity));
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
                var respnse = await _service.DeleteAsync<APIResponse>(entity.Id);
                if (respnse != null && respnse.IsSuccess)
                {
                    return RedirectToAction(nameof(Index));
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
