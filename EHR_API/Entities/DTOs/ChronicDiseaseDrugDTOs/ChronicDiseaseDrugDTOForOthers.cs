using EHR_API.Entities.DTOs.MedicationDTOs;

namespace EHR_API.Entities.DTOs.ChronicDiseaseDrugDTOs
{
    public class ChronicDiseaseDrugDTOForOthers
    {
        //public int MedicationId { get; set; }
        public int ChronicDiseaseId { get; set; }
        public MedicationDTOForOthers Medication { get; set; }
    }
}
