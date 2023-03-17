using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR_API.Entities.Models
{
    public class ChronicDiseaseDrug
    {
        [Key]
        public int Id { get; set; }
        public int MedicationId { get; set; }
        public string ICDId { get; set; }
        public string RegistrationDataId { get; set; }

        public Medication Medication { get; set; }
        public ChronicDisease ChronicDisease { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
