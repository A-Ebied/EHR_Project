using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration
{
    public class RegistrationDataUpdateDTO
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string UserName { get; init; }
        [Required]
        public string Password { get; init; }
        [Required]
        public string Email { get; init; }
        public string PhoneNumber { get; init; }

        [Required]
        public ICollection<string> Roles { get; init; }
    }
}
