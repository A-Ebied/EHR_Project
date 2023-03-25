using EHR_API.Entities.DTOs.AllergyDrugDTOs;

namespace EHR_API.Entities.DTOs.RadLabResultDTOs
{
    public class RadLabResultDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Allergen { get; set; }
        public string Reaction { get; set; }
        public string Instruction { get; set; }
        public bool IsChronic { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public IEnumerable<AllergyDrugDTOForOthers> AllergyDrugs { get; set; }
    }
}
