namespace EHR_API.Entities.Models
{
    public class Admit
    {
        public int VisitId { get; set; }
        
        //public string Type { get; set; }
        public string Reason { get; set; }
        public string Place { get; set; }
        public DateTime AdmitAt { get; set; }
        public DateTime LeaveAt { get; set; }
        public int HealthFacilityId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Visit Visit { get; set; }
        public HealthFacility HealthFacility { get; set; }
        public ICollection<Surgery> Surgeries { get; set; }
        public ICollection<ReceiveBlood> ReceiveBloods { get; set; }
    }
}
