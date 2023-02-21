using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EHR_MVC.DTOs.HealthFacilityDTOs
{
    public class HealthFacilityCreateDTO
    {
        [Required, MaxLength(80, ErrorMessage = "The maximum length is 80 characters")]
        public string Title { get; set; }
        [Required, MaxLength(20, ErrorMessage = "The maximum length is 20 characters")]
        public string Type { get; set; }
        [Required, MaxLength(20, ErrorMessage = "The maximum length is 20 characters")]
        [DisplayName("Subordinate To")]
        public string SubordinateTo { get; set; }
        [Required, MaxLength(11, ErrorMessage = "The maximum length is 11 characters")]
        public string Phone1 { get; set; }
        [MaxLength(11, ErrorMessage = "The maximum length is 11 characters")]
        public string Phone2 { get; set; }
        [MaxLength(11, ErrorMessage = "The maximum length is 11 characters")]
        public string Phone3 { get; set; }
        [Required, RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0,9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        [Required, MaxLength(250, ErrorMessage = "The maximum length is 250 characters")]
        public string Address { get; set; }
        [MaxLength(500, ErrorMessage = "The maximum length is 500 characters")]
        public string Description { get; set; }

        [Required]
        public int GovernorateId { get; set; }
        [Required]
        public string RegistrationDataId { get; set; }
    }
}
