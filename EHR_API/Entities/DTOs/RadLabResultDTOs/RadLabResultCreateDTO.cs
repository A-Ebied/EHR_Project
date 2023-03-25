using System.ComponentModel.DataAnnotations;
using EHR_API.Entities.DTOs.AllergyDrugDTOs;
using EHR_API.Entities.Models;

namespace EHR_API.Entities.DTOs.RadLabResultDTOs
{
    public class RadLabResultCreateDTO
    {
        [Required]
        public int Id { get; set; }
        public string ResultNote { get; set; }
        [Required]
        public int VisitRadLabTestId { get; set; }
        [Required]
        public int HealthFacilityId { get; set; }
       // public ICollection<RadLabResultImagesCreateDTO> RadiologyResultImages { get; set; }
    }
}
