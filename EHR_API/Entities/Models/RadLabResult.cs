using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.Models
{
    public class RadLabResult
    {
        [Key]
        public int Id { get; set; }
        //public double Price { get; set; }
        //public bool UnderInsurance { get; set; }
        public string ResultNote { get; set; }
        public int VisitRadLabTestId { get; set; }
        public int HealthFacilityId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
         
        public VisitRadLabTest VisitRadLabTest { get; set; }
        public HealthFacility HealthFacility { get; set; }
        public ICollection<RadLabResultImage> RadiologyResultImages { get; set; }
    }
}
