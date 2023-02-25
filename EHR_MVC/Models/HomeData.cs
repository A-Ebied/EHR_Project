using EHR_MVC.DTOs.GovernorateDTOs;
using EHR_MVC.DTOs.HealthFacilityDTOs;
using EHR_MVC.DTOs.UserDataDTOs;
using EHR_MVC.DTOs.UserDataDTOs.MedicalTeamDTOs;

namespace EHR_MVC.Models
{
    public class HomeData
    {
        public IEnumerable<GovernorateDTOForOthers> Governorates { get; set; }
        public IEnumerable<HealthFacilityDTOForOthers> HealthFacilities  { get; set; }
        public IEnumerable<UserDTOForOthers> MedicalTeam { get; set; }
    }
}
