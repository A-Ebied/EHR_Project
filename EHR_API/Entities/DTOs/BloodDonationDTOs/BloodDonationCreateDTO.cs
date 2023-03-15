using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.BloodDonationDTOs
{
    public class BloodDonationCreateDTO
    {
        [Required]
        public DateTime DonationDateTime { get; set; }
        [Required]
        public string RegistrationDataId { get; set; } // dropdownlist
         [Required]
        public string MedicalTeamId { get; set; } // hidden input

    }
}
