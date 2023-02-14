using System.ComponentModel;

namespace EHR_API.Entities.DTOs.UserDataDTOs
{
    public class PatientDTOForOthers
    {
        public string Id { get; set; }
        [DisplayName("Age Group")]
        public string AgeGroup { get; set; }
        [DisplayName("Is Sane?")]
        public bool IsSane { get; set; } 
    }
}
