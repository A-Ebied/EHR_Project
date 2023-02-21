using AutoMapper;
using EHR_MVC.DTOs.GovernorateDTOs;
using EHR_MVC.DTOs.HealthFacilityDTOs;
using EHR_MVC.Models;
using EHR_MVC.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace EHR_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGovernorateService _governorateService;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IGovernorateService governorateService, IMapper mapper)
        {
            _logger = logger;
            _governorateService = governorateService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var homeData = new HomeData();

            var respnse = await _governorateService.GetAllAsync<APIResponse>();
            if (respnse != null && respnse.IsSuccess)
            {
                homeData.Governorates = JsonConvert.DeserializeObject<List<GovernorateDTOForOthers>>(
                    Convert.ToString(respnse.Result)).Take(4);
                
                homeData.HealthFacilities = JsonConvert.DeserializeObject<List<HealthFacilityDTOForOthers>>(
                    Convert.ToString(respnse.Result)).Take(4);
            }

            return View(homeData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}