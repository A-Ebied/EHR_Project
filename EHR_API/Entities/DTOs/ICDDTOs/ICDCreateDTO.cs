using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.AllergyDTOs
{
    public class ICDCreateDTO
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string DiagnosisName { get; set; }
    }
}
