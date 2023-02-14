using EHR_API.Entities.Models.UsersData;
using EHR_API.Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserDataDTOs
{
    public class MedicalDataCreateDTO
    {
        [Required] 
        public string Id { get; set; }
        [Required]
        public string BloodGroup { get; set; }
        public string FamilyHistory { get; set; }
        public string MedicalHistory { get; set; }
        public string DNAImageResultUrl { get; set; }
    }
}
