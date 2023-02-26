using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Entities.Models
{
    public class ChronicDisease
    {
        public string ICDId { get; set; }
        public ICD ICD { get; set; }
        public string RegistrationDataId { get; set; }
        public RegistrationData RegistrationData { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
 
        public ICollection<ChronicDiseaseDrug> ChronicDiseaseDrugs { get; set; }
    }
}
