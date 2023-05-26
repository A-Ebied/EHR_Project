namespace EHR_API.Entities.DTOs.PhysicalTherapyDTOs
{
    public class PhysicalTherapyDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Target { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public int VisitId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
