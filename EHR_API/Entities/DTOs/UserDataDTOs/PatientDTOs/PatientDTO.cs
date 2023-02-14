using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_API.Entities.DTOs.GovernorateDTOs;
using System.ComponentModel;

namespace EHR_API.Entities.DTOs.UserDataDTOs
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
