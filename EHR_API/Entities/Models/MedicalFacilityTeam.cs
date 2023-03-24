using EHR_API.Entities.Models.UsersData;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class MedicalFacilityTeam
    {
        [Key]
        public int Id { get; set; }
        public string MedicalTeamId { get; set; }
        public int HealthFacilityId { get; set; }
        public DateTime CreatedAt { get; set; }

        public MedicalTeam MedicalTeam { get; set; }
        public HealthFacility HealthFacility { get; set; }
    }
}
