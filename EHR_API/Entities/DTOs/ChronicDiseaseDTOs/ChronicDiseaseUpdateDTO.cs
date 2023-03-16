using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.ChronicDiseaseDTOs
{
    public class ChronicDiseaseUpdateDTO
    {
        [Required]
        public string ICDId { get; set; }
        [Required]
        public string RegistrationDataId { get; set; }
    }
}
