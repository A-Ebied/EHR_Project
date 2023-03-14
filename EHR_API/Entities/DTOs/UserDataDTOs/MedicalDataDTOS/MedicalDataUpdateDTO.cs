using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserDataDTOs.MedicalDataDTOs
{
    public class MedicalDataUpdateDTO
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string BloodGroup { get; set; }
        public string FamilyHistory { get; set; }
        public string MedicalHistory { get; set; }
        public byte[] DNAImageResult { get; set; }
        public string ImageName { get; set; }
    }
}
