using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.MedicationDTOs
{
    public class MedicationCreateDTO
    {
        [Required]
        public int Id { get; set; }
        public byte[] MedicationImage { get; set; }
        public string ImageName { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Contraindication { get; set; }
    }
}
