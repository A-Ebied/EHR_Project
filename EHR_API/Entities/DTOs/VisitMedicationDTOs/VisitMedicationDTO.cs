using EHR_API.Entities.DTOs.AllergyDrugDTOs;
using EHR_API.Entities.DTOs.MedicationDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.VisitMedicationDTOs
{
    public class VisitMedicationDTO
    {
        public int VisitId { get; set; }
        public int MedicationId { get; set; }
        public string Dosage { get; set; }
        public string DosageNote { get; set; }
        public string NoOfDays { get; set; }
        public string Route { get; set; }
        public string Frequency { get; set; }
        public string FoodRelation { get; set; }
        public string Instruction { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateddAt { get; set; }
    }
}
