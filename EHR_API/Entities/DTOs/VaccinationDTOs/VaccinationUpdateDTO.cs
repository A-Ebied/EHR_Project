using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.VaccinationDTOs
{
    public class VaccinationUpdateDTO
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Reason { get; set; }
        [Required]
        public string Route { get; set; }
        [Required]
        public string AgeRange { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public string NumberOfTimes { get; set; }
        [Required]
        public string Dosage { get; set; }
        public string DosageNote { get; set; }
        [Required]
        public string Quantity { get; set; }
        public string Contraindication { get; set; }
        public string SideEffects { get; set; }
        [Required]
        public bool IsMandatory { get; set; } = false;
        public string Note { get; set; } 
    }
}
