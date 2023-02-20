using System.ComponentModel;

namespace EHR_MVC.DTOs.UserDataDTOs.PatientDTOs
{
    public class PatientDTO
    {
        public string Id { get; set; }
        [DisplayName("Age Group")]
        public string AgeGroup { get; set; }
        [DisplayName("Is Sane?")]
        public bool IsSane { get; set; }
        [DisplayName("Created at")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Updated at")]
        public DateTime UpdateddAt { get; set; }
    }
}
