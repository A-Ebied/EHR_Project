namespace EHR_API.Entities.Models.UsersData
{
    public class MedicalTeam
    {
        public string Id { get; set; }
        public string MedicalSpecialization { get; set; }
        public string Degree { get; set; }
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdateddAt { get; set; } 

        public RegistrationData RegistrationData { get; set; }
        //public ICollection<MedicalFacilityTeam> MedicalFacilityTeams { get; set; }
        //public ICollection<Visit> Visits { get; set; }
    }
}
