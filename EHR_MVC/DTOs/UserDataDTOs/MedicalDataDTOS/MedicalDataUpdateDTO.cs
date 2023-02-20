using System.ComponentModel.DataAnnotations;

namespace EHR_MVC.DTOs.UserDataDTOs.MedicalDataDTOS
{
    public class MedicalDataUpdateDTO
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string BloodGroup { get; set; }
        public string FamilyHistory { get; set; }
        public string MedicalHistory { get; set; }
        //public string DNAImageResultUrl { get; set; }
        public IFormFile DNAImageResult { get; set; }
    }
}
