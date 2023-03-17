using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class ChronicDiseaseDrug
    {
        [Key]
        public int Id { get; set; }
        public int MedicationId { get; set; }
        public int ChronicDiseaseId { get; set; }

        public Medication Medication { get; set; }
        public ChronicDisease ChronicDisease { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
