namespace EHR_MVC.DTOs.AdmitDTOs
{
    public class AdmitDTO
    {
        public int Id { get; set; }
        public DateTime AdmitAt { get; set; }
        public DateTime LeaveAt { get; set; }
        public string MedicalTeamId { get; set; }
        public int HealthFacilityId { get; set; }
        public string RegistrationDataId { get; set; }
        public string Reason { get; set; }
        public string Place { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //public HealthFacilityDTOForOthers HealthFacility { get; set; }
        //public ICollection<SurgeryDTOForOthers> Surgeries { get; set; }
        //public ICollection<ReceiveBloodDataDTOForOthers> ReceiveBloods { get; set; }
    }
}