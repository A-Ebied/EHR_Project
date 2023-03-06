using EHR_API.Entities.Models;

namespace EHR_API.Entities.DTOs.VisitVitalSignDTOs
{
    public class VisitVitalSignDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public int VisitId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
