namespace EHR_API.Entities.Models
{
    public class PhysicalTherapy
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Target { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int VisitId { get; set; }
        public Visit Visit { get; set; }

        //public ICollection<PhysicalTherapyInvoice>? PhysicalTherapyInvoices { get; set; }
    }
}
