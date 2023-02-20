using System.ComponentModel;

namespace EHR_MVC.DTOs.UserDataDTOs.MedicalTeamDTOs
{
    public class MedicalTeamDTO
    {
        public string Id { get; set; }
        public string MedicalSpecialization { get; set; }
        public string Degree { get; set; }
        [DisplayName("Created at")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Updated at")]
        public DateTime UpdateddAt { get; set; }
    }
}
