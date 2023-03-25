using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.AllergyDTOs
{
    public class AllergyUpdateDTO
    {
        [Required]
        public int Id { get; set; }
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
    }
}
