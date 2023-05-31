using EHR_API.Entities.DTOs.RadLabResultImageDTOs;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.RadLabResultDTOs
{
    public class RadLabResultCreateDTO
    {
        public string ResultNote { get; set; }
        [Required]
        public int VisitRadLabTestId { get; set; }
        [Required]
        public int HealthFacilityId { get; set; }

        public ICollection<IFormFile> ResultImages { get; set; }
    }
}
