using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Entities.Models
{
    //موانع
    public class Contraindication
    {
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
