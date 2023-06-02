using EHR_API.Entities.DTOs.AllergyDrugDTOs;

namespace EHR_API.Entities.DTOs.AllergyDTOs
{
    public class AllergyDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Allergen { get; set; }
        public string Reaction { get; set; }
        public string Instruction { get; set; }
        public string IsChronicStr { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<object> Drugs { get; set; }
    }
}
