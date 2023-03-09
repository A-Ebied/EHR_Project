using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.VisitRadLabTestDTOS
{
    public class VisitRadLabTestUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string TestType { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int VisitId { get; set; }
    }
}
