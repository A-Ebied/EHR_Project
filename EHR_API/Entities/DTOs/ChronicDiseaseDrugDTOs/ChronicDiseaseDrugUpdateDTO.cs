using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.ChronicDiseaseDrugDTOs
{
    public class ChronicDiseaseDrugUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int MedicationId { get; set; }
        [Required]
        public int ChronicDiseaseId { get; set; }


    }
}
