using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Login
{
    public class LoginRequestDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
