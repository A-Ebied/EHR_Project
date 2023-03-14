using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserDataDTOs.MedicalTeamDTOs
{
    public class MedicalTeamCreateDTO
    {
        [Required] 
        public string Id { get; set; }
        [Required]
        public string MedicalSpecialization { get; set; }
        [Required]
        public string Degree { get; set; }
    }
}
