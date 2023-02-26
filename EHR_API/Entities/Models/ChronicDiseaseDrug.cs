using System.ComponentModel.DataAnnotations.Schema;

namespace EHR_API.Entities.Models
{
    public class ChronicDiseaseDrug
    {
        [ForeignKey("Medication")]
        public int MedicationId { get; set; }
        public Medication Medication { get; set; }
        public string ICDId { get; set; }
        public string RegistrationDataId { get; set; }

        [ForeignKey("ICDId, RegistrationDataId")]
        public ChronicDisease ChronicDisease { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
