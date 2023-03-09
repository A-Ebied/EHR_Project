using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.HealthFacilityDTOs
{
    public class HealthFacilityUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string SubordinateTo { get; set; }
        [Required]
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        [Required, RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0,9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        public string Description { get; set; }

        [Required]
        public int GovernorateId { get; set; }
        [Required]
        public string RegistrationDataId { get; set; }
    }
}
