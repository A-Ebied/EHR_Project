using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class AllergyDrug
    {
        [Key]
        public int Id { get; set; }
        public int AllergyId { get; set; }
        public int MedicationId { get; set; }
        public Allergy Allergy { get; set; }
        public Medication Medication { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
