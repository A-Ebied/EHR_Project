using AutoMapper;
using EHR_MVC.DTOs.GovernorateDTOs;
using EHR_MVC.DTOs.HealthFacilityDTOs;
using EHR_MVC.DTOs.UserDataDTOs;
using EHR_MVC.DTOs.UserDataDTOs.MedicalTeamDTOs;
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
        private readonly IHealthFacilityService _healthService;
        private readonly IAuthenService _auth;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IGovernorateService governorateService, IMapper mapper, IHealthFacilityService healthService, IAuthenService auth)
        {
            _logger = logger;
            _governorateService = governorateService;
            _healthService = healthService;
            _auth = auth;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var homeData = new HomeData();

            var gov = await _governorateService.GetAllAsync<APIResponse>();
            if (gov != null && gov.IsSuccess)
            {
                homeData.Governorates = JsonConvert.DeserializeObject<List<GovernorateDTOForOthers>>(
                    Convert.ToString(gov.Result)).Take(4);
            }

            var heal = await _healthService.GetAllAsync<APIResponse>();
            if (heal != null && heal.IsSuccess)
            {
                homeData.HealthFacilities = JsonConvert.DeserializeObject<List<HealthFacilityDTOForOthers>>(
                    Convert.ToString(heal.Result)).Take(4);
            }

            var med = await _auth.GetMedicalUsersAsync<APIResponse>();
            if (med != null && med.IsSuccess)
            {
                homeData.MedicalTeam = JsonConvert.DeserializeObject<List<UserDTOForOthers>>(
                    Convert.ToString(med.Result)).Take(4);
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