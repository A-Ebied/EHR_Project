using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.PhysicalTherapyDTOs
{
    public class PhysicalTherapyUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Target { get; set; }
        public string Description { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public int VisitId { get; set; }
    }
}
