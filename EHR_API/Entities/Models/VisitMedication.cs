using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class VisitMedication
    {
        [Key]
        public int Id { get; set; }
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
        public DateTime UpdatedAt { get; set; }

        public Visit Visit { get; set; }
        public Medication Medication { get; set; }

    }
}
