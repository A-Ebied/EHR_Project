using EHR_API.Entities.Models.UsersData;

namespace EHR_API.Entities.Models
{
    public class MedicalFacilityTeam
    {
        public string MedicalTeamId { get; set; }
        public MedicalTeam MedicalTeam { get; set; }
        public int HealthFacilityId { get; set; }
        public HealthFacility HealthFacility { get; set; }
    }
}
