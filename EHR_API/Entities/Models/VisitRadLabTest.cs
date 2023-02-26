using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class VisitRadLabTest
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string TestType { get; set; }
        public string Description { get; set; }
        public int VisitId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Visit Visit { get; set; }
        public ICollection<RadLabResult> VisitRadiologyResults { get; set; }
    }
}
