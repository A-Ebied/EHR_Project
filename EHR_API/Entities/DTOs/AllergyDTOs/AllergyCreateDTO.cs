using System.ComponentModel.DataAnnotations;
using EHR_API.Entities.DTOs.AllergyDrugDTOs;

namespace EHR_API.Entities.DTOs.AllergyDTOs
{
    public class AllergyCreateDTO
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Allergen { get; set; }
        public string Reaction { get; set; }
        public string Instruction { get; set; }
        [Required]
        public bool IsChronic { get; set; }
        [Required]
        public string RegistrationDataId { get; set; }

        public ICollection<AllergyDrugCreateDTO> AllergyDrugs { get; set; }
    }
}
