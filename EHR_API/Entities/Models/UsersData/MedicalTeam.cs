using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models.UsersData
{
    public class MedicalTeam
    {
        [Key]
        public string Id { get; set; }
        public string MedicalSpecialization { get; set; }
        public string Degree { get; set; }
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; } 

        public RegistrationData RegistrationData { get; set; }
        public ICollection<HealthFacility> HealthFacilities { get; set; }
        public ICollection<MedicalFacilityTeam> MedicalFacilityTeams { get; set; }
        public ICollection<Visit> Visits { get; set; }
        public ICollection<Admit> Admits { get; set; }
        public ICollection<Allergy> Allergies { get; set; }
    }
}
