using EHR_API.Entities.DTOs.HealthFacilityDTOs;

namespace EHR_API.Entities.DTOs.RadLabResultDTOs
{
    public class RadLabResultDTO
    {
        public int Id { get; set; }
        public string ResultNote { get; set; }
        public string ImageUrl { get; set; }
        public string FileUrl { get; set; }
        public int VisitRadLabTestId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public HealthFacilityDTOForOthers HealthFacility { get; set; }
    }
}
