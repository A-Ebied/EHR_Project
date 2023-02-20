using EHR_MVC.DTOs.GovernorateDTOs;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EHR_MVC.DTOs.HealthFacilityDTOs
{
    public class HealthFacilityDTOForOthers
    {
        [DisplayName("Health Facility No.")]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        [DisplayName("Subordinate To")]
        public string SubordinateTo { get; set; }
    }
}
