using System.ComponentModel.DataAnnotations;

namespace EHR_MVC.DTOs.UserDataDTOs.MedicalTeamDTOs
{
    public class MedicalTeamUpdateDTO
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string MedicalSpecialization { get; set; }
        [Required]
        public string Degree { get; set; }
    }
}
