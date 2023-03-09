namespace EHR_API.Entities.DTOs.VisitDTOs
{
    public class VisitDTOForOthers
    {
        public int Id { get; set; }
        public string RegistrationDataId { get; set; }
        public string MedicalTeamId { get; set; }
        public int HealthFacilityId { get; set; }
        public string VisitType { get; set; }
        public string ICDId { get; set; }
    }
}
