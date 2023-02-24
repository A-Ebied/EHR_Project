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
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [MaxLength(11, ErrorMessage = "The maximum length is 11 characters")]
        public string PhoneNumber { get; set; }

        //[Required]
        //public ICollection<string> Roles { get; set; } 
        [Required]
        public string Role { get; set; }
    }
}
