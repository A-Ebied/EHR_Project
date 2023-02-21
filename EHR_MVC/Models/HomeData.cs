using EHR_MVC.DTOs.GovernorateDTOs;

namespace EHR_MVC.Models
{
    public class HomeData
    {
        public IEnumerable<GovernorateDTOForOthers> Governorates { get; set; }
    }
}
