using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.MedicalFacilityTeamDTOs
{
    public class MedicalFacilityTeamCreateDTO
    {
        [Required]
        public string MedicalTeamId { get; set; }
        [Required]
        public int HealthFacilityId { get; set; }
    }
}
