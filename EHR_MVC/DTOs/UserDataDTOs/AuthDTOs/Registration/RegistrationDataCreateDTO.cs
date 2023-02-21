using System.ComponentModel.DataAnnotations;

namespace EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Registration
{
    public class RegistrationDataCreateDTO
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
        [MaxLength(11, ErrorMessage = "The maximum length is 11 characters")]
        public string PhoneNumber { get; init; }

        [Required]
        public ICollection<string> Roles { get; init; }
    }
}
