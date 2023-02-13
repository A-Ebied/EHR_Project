namespace EHR_API.Entities.Models.UsersData
{
    public class Patient
    {
        public string Id { get; set; }

        public string AgeGroup { get; set; }
        public bool IsSane { get; set; }


        public RegistrationData RegistrationData { get; set; }
    }
}
