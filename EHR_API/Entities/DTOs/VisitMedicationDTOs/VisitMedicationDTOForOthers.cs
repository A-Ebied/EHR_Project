namespace EHR_API.Entities.DTOs.VisitMedicationDTOs
{
    public class VisitMedicationDTOForOthers
    {
        public int VisitId { get; set; }
        public int MedicationId { get; set; }
        public string Dosage { get; set; }
    }
}
