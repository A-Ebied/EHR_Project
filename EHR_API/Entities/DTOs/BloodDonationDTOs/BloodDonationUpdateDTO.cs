using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.BloodDonationDTOs
{
    public class BloodDonationUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime DonationDateTime { get; set; }
        [Required]
        public string RegistrationDataId { get; set; }
        [Required]
        public string MedicalTeamId { get; set; }
    }
}
