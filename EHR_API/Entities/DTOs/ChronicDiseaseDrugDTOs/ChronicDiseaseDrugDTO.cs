using EHR_API.Entities.DTOs.MedicationDTOs;

namespace EHR_API.Entities.DTOs.ChronicDiseaseDrugDTOs
{
    public class ChronicDiseaseDrugDTO
    {
        public int MedicationId { get; set; }
        public MedicationDTOForOthers Medication { get; set; }

        public string ICDId { get; set; }
        public string RegistrationDataId { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
