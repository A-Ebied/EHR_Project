using EHR_MVC.DTOs.UserDataDTOs;
using EHR_MVC.DTOs.GovernorateDTOs;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EHR_MVC.DTOs.HealthFacilityDTOs
{
    public class HealthFacilityDTO
    {
        [DisplayName("Health Facility No.")]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        [DisplayName("Subordinate To")]
        public string SubordinateTo { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        [DisplayName("Created at")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Updated at")]
        public DateTime UpdateddAt { get; set; }

        public string Governorate { get; set; }
        public UserDTOForOthers Manager { get; set; }
    }
}
