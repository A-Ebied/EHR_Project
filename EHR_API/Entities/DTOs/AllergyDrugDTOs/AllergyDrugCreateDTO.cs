using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.AllergyDrugDTOs
{
    public class AllergyDrugCreateDTO
    {
        [Required]
        public int AllergyId { get; set; }
        [Required]
        public int MedicationId { get; set; }
    }
}
