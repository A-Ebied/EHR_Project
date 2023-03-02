using EHR_API.Entities.DTOs.AllergyDrugDTOs;
using EHR_API.Entities.DTOs.MedicationDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs;
using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Entities.DTOs.BloodDonationDTOs
{
    public class BloodDonationDTO
    {
        public int Id { get; set; }
        public DateTime DonationDateTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public UserDTOForOthers User { get; set; }
        public UserDTOForOthers MedicalTeam { get; set; }
    }
}
