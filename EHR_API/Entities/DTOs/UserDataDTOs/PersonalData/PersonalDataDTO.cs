using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration;

namespace EHR_API.Entities.DTOs.UserDataDTOs
{
    public class PersonalDataDTO
    {
        public string Id { get; set; }

        public string AgeGroup { get; set; }
        public bool IsSane { get; set; }


        public RegistrationDataDTO RegistrationData { get; set; }
    }
}
