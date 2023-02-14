namespace EHR_API.Entities.Models.UsersData
{
    public class MedicalTeam
    {
        public string Id { get; set; }
        public string MedicalSpecialization { get; set; }
        public string Degree { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdateddAt { get; set; } = DateTime.Now;

        public RegistrationData RegistrationData { get; set; }
        //public ICollection<MedicalFacilityTeam> MedicalFacilityTeams { get; set; }
        //public ICollection<Visit> Visits { get; set; }
    }
}
