using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.VaccinationDTOs
{
    public class VaccinationCreateDTO
    {
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
        public string Dosage { get; set; }
        [Required]
        public string VaccinationEffectiveness { get; set; }
        public string Contraindication { get; set; }
        public string SideEffects { get; set; }
        public string Note { get; set; }
    }
}
