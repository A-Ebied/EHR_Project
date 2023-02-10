using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs
{
    public class LoginResponseDTO
    {
        public RegistrationData User { get; set; }
        public string Token { get; set; }
    }
}
