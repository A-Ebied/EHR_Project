namespace EHR_API.Entities.DTOs.MedicalFacilityTeamDTOs
{
    public class MedicalFacilityTeamDTO
    {
        public int Id { get; set; }
        public string MedicalTeamId { get; set; }
        public int HealthFacilityId { get; set; }
    }
}
