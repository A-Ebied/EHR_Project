using EHR_MVC.DTOs.GovernorateDTOs;
using EHR_MVC.DTOs.HealthFacilityDTOs;

namespace EHR_MVC.Models
{
    public class HomeData
    {
        public IEnumerable<GovernorateDTOForOthers> Governorates { get; set; }
        public IEnumerable<HealthFacilityDTOForOthers> HealthFacilities  { get; set; }
    }
}
