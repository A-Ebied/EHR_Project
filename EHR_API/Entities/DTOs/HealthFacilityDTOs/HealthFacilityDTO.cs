using EHR_API.Entities.DTOs.MedicalFacilityTeamDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs;
using System.ComponentModel;

namespace EHR_API.Entities.DTOs.HealthFacilityDTOs
{
    public class HealthFacilityDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string SubordinateTo { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public string Governorate { get; set; }
        public UserDTOForOthers Manager { get; set; }
        public ICollection<UserDTOForOthers> MedicalTeams { get; set; }
    }
}
