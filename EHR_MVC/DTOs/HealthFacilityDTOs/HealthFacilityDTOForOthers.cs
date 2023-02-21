using EHR_MVC.DTOs.GovernorateDTOs;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EHR_MVC.DTOs.HealthFacilityDTOs
{
    public class HealthFacilityDTOForOthers
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string SubordinateTo { get; set; }
    }
}
