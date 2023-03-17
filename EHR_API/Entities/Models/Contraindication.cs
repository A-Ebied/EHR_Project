using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    //موانع
    public class Contraindication
    {
        [Key]
        public int Id { get; set; }
        public string ContraindiReason { get; set; }
        public string ItsEffect { get; set; }
        public bool IsChronic { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int MedicationId { get; set; }
        public Medication Medication { get; set; }
        public string RegistrationDataId { get; set; }
        public RegistrationData RegistrationData { get; set; }
    }
}
