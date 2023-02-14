namespace EHR_API.Entities.Models.UsersData
{
    public class Patient
    {
        public string Id { get; set; }
        public string AgeGroup { get; set; }
        public bool IsSane { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdateddAt { get; set; } = DateTime.Now;

        public RegistrationData RegistrationData { get; set; }
    }
}
