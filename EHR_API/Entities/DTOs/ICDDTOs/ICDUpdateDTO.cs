using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.ICDDTOs
{
    public class ICDUpdateDTO
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string DiagnosisName { get; set; }
    }
}
