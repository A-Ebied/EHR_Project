using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class BloodDonation
    {
        [Key]
        public int Id { get; set; }
        public DateTime DonationDateTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public string RegistrationDataId { get; set; }
        public RegistrationData RegistrationData { get; set; }
        public string MedicalTeamId { get; set; }
        public MedicalTeam MedicalTeam { get; set; }
    }
}
