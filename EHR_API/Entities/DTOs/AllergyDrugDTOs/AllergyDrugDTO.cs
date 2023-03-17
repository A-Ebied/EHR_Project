using EHR_API.Entities.DTOs.AllergyDTOs;
using EHR_API.Entities.DTOs.MedicationDTOs;

namespace EHR_API.Entities.DTOs.AllergyDrugDTOs
{
    public class AllergyDrugDTO
    {
        public int Id { get; set; }
        public int AllergyId { get; set; }
        public int MedicationId { get; set; }
        public AllergyDTOForOthers Allergy { get; set; }
        public MedicationDTOForOthers Medication { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}