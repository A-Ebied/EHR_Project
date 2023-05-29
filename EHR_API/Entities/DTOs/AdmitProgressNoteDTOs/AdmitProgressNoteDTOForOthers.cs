namespace EHR_API.Entities.DTOs.AdmitProgressNoteDTOs
{
    public class AdmitProgressNoteDTOForOthers
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string MedicalTeamId { get; set; }
        public int SurgeryId { get; set; }
    }
}
