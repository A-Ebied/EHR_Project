using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.MedicationDTOs
{
    public class MedicationUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        public IFormFile MedicationImage { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Contraindication { get; set; }
    }
}
