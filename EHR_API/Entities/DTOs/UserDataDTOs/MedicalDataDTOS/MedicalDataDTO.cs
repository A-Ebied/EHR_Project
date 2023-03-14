using System.ComponentModel;

namespace EHR_API.Entities.DTOs.UserDataDTOs.MedicalDataDTOs
{
    public class MedicalDataDTO
    {
        public string Id { get; set; }
        public string BloodGroup { get; set; }
        public string FamilyHistory { get; set; }
        public string MedicalHistory { get; set; }
        public string DNAImageResultUrl { get; set; }
        [DisplayName("Created at")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Updated at")]
        public DateTime UpdatedAt { get; set; }
    }
}
