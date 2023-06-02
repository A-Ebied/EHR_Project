using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR_API.Entities.Models.UsersData
{
    public class MedicalData
    {
        [Key]
        public string Id { get; set; }
        public string BloodGroup { get; set; }
        public string FamilyHistory { get; set; }
        public string MedicalHistory { get; set; }
        public string DNAImageResultUrl { get; set; }
        [NotMapped]
        public IFormFile DNAImageResult { get; set; }

        public DateTime CreatedAt { get; set; }  
        public DateTime UpdatedAt { get; set; }  

        public RegistrationData RegistrationData { get; set; }
    }
}
