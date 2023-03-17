using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class Admit
    {
        [Key]
        public int Id { get; set; }
        public string MedicalTeamId { get; set; }
        public int HealthFacilityId { get; set; }
        public string RegistrationDataId { get; set; }
        public string Reason { get; set; }
        public string Place { get; set; }
        public DateTime AdmitAt { get; set; }
        public DateTime LeaveAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public MedicalTeam MedicalTeam { get; set; }
        public HealthFacility HealthFacility { get; set; }
        public RegistrationData RegistrationData { get; set; }
        public ICollection<Surgery> Surgeries { get; set; }
        public ICollection<ReceiveBlood> ReceiveBloods { get; set; }
    }
}
