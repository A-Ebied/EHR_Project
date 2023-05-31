using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.RadLabResultDTOs
{
    public class RadLabResultCreateDTO
    {
        public string ResultNote { get; set; }
        [Required]
        public IFormFile Image { get; set; }
        public IFormFile File { get; set; }
        [Required]
        public int VisitRadLabTestId { get; set; }
        [Required]
        public int HealthFacilityId { get; set; }
    }
}
