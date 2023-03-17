using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.ChronicDiseaseDrugDTOs
{
    public class ChronicDiseaseDrugCreateDTO
    {
        [Required]
        public int MedicationId { get; set; }
        [Required]
        public int ChronicDiseaseId { get; set; }
    }
}
