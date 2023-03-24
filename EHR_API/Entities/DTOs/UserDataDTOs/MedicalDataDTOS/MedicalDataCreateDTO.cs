using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserDataDTOs.MedicalDataDTOs
{
    public class MedicalDataCreateDTO
    {
        [Required] 
        public string Id { get; set; }
        [Required]
        public string BloodGroup { get; set; }
        public string FamilyHistory { get; set; }
        public string MedicalHistory { get; set; }
        //public byte[] DNAImageResult { get; set; }
        public IFormFile DNAImageResult { get; set; }
        public string ImageName { get; set; }
    }
}
