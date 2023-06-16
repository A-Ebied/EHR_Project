using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class Admit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MedicalTeamId { get; set; }
        [Required]
        public int HealthFacilityId { get; set; }
        [Required]
        public string RegistrationDataId { get; set; }
        [Required, MinLength(3)]
        public string Reason { get; set; }
        [Required, MinLength(3)]
        public string Place { get; set; }
        [Required]
        public DateTime AdmitAt { get; set; }
        public DateTime? LeaveAt { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public MedicalTeam MedicalTeam { get; set; }
        public HealthFacility HealthFacility { get; set; }
        public RegistrationData RegistrationData { get; set; }
        public ICollection<Surgery> Surgeries { get; set; }
        public ICollection<ReceiveBlood> ReceiveBloods { get; set; }
        public ICollection<AdmitProgressNote> AdmitProgressNotes { get; set; }
    }
}
