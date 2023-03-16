using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.VisitRadLabTestDTOs
{
    public class VisitRadLabTestCreateDTO
    {
        [Required]
        public string TestType { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int VisitId { get; set; }
    }
}
