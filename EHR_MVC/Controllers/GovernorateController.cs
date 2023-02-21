using AutoMapper;
using EHR_MVC.DTOs.GovernorateDTOs;
using EHR_MVC.Models;
using EHR_MVC.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EHR_MVC.Controllers
{
    public class GovernorateController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGovernorateService _service;
        public GovernorateController(IMapper mapper, IGovernorateService service)
        {
            _mapper = mapper;
            _service = service;
        }
         
        // GET: GovernorateController
        public async Task<IActionResult> Index()
        {
            List<GovernorateDTOForOthers> list = new();

            var respnse = await _service.GetAllAsync<APIResponse>();
            if (respnse != null && respnse.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<GovernorateDTOForOthers>>(
                    Convert.ToString(respnse.Result));
            }

            return View(list);
        }

        // GET: GovernorateController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            GovernorateDTO entity = new();

            var respnse = await _service.GetAsync<APIResponse>(id);
            if (respnse != null && respnse.IsSuccess)
            {
                entity = JsonConvert.DeserializeObject<GovernorateDTO>(
                    Convert.ToString(respnse.Result));

                return View(entity);
            }

            return NotFound();
        }

        // GET: GovernorateController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: GovernorateController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GovernorateCreateDTO entity)
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

        // GET: GovernorateController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            GovernorateDTO entity = new();

            var respnse = await _service.GetAsync<APIResponse>(id);
            if (respnse != null && respnse.IsSuccess)
            {
                entity = JsonConvert.DeserializeObject<GovernorateDTO>(
                    Convert.ToString(respnse.Result));

                return View(_mapper.Map<GovernorateUpdateDTO>(entity));
            }

            return NotFound();
        }

        // POST: GovernorateController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, GovernorateUpdateDTO entity)
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

        // GET: GovernorateController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            GovernorateDTO entity = new();

            var respnse = await _service.GetAsync<APIResponse>(id);
            if (respnse != null && respnse.IsSuccess)
            {
                entity = JsonConvert.DeserializeObject<GovernorateDTO>(
                    Convert.ToString(respnse.Result));

                return View(_mapper.Map<GovernorateDTOForOthers>(entity));
            }

            return NotFound();
        }

        // POST: GovernorateController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(GovernorateDTOForOthers entity)
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
