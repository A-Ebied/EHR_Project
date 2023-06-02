using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class HealthFacility
    {
        [Key]
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

        public string MedicalTeamId { get; set; }
        public int GovernorateId { get; set; }

        public Governorate Governorate { get; set; }
        public MedicalTeam MedicalTeam { get; set; }
        public ICollection<MedicalFacilityTeam> MedicalFacilityTeams { get; set; }
        public ICollection<Visit> Visits { get; set; }
    }
}
