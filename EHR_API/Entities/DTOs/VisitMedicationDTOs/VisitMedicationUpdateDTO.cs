using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.VisitMedicationDTOs
{
    public class VisitMedicationUpdateDTO
    {
        [Required]
        public int VisitId { get; set; }
        [Required]
        public int MedicationId { get; set; }
        [Required]
        public string Dosage { get; set; }
        public string DosageNote { get; set; }
        [Required]
        public string NoOfDays { get; set; }
        public string Route { get; set; }
        [Required]
        public string Frequency { get; set; }
        [Required]
        public string FoodRelation { get; set; }
        public string Instruction { get; set; }
    }
}
