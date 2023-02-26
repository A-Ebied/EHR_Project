namespace EHR_API.Entities.Models
{
    public class AllergyDrug
    {
        public int AllergyId { get; set; }
        public int MedicationId { get; set; }
        public Allergy Allergy { get; set; }
        public Medication Medication { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
