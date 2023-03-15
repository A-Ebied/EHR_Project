using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.BloodDonationDTOs
{
    public class BloodDonationUpdateDTO
    {
        [Required]
        public int Id { get; set; }  // hidden input
        [Required]
        public DateTime DonationDateTime { get; set; }
        [Required]
        public string RegistrationDataId { get; set; }  // dropdownlist
        [Required]
        public string MedicalTeamId { get; set; }  // hidden input
    }
}
