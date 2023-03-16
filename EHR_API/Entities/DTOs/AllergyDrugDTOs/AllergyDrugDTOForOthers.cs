using EHR_API.Entities.DTOs.MedicationDTOs;

namespace EHR_API.Entities.DTOs.AllergyDrugDTOs
{
    public class AllergyDrugDTOForOthers
    {
        public int AllergyId { get; set; }
        public int MedicationId { get; set; }
        //public MedicationDTOForOthers Medication { get; set; }
    }
}