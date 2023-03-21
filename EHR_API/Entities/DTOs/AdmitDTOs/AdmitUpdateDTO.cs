using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.AdmitDTOs
{
    public class AdmitUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime AdmitAt { get; set; }
        public DateTime? LeaveAt { get; set; }
        [Required]
        public string MedicalTeamId { get; set; }
        [Required]
        public int HealthFacilityId { get; set; }
        [Required]
        public string RegistrationDataId { get; set; }
        [Required]
        public string Reason { get; set; }
        [Required]
        public string Place { get; set; }
        public string Note { get; set; }
    }
}