using EHR_API.Entities.DTOs.HealthFacilityDTOs;
using EHR_API.Entities.DTOs.RadLabResultImageDTOs;

namespace EHR_API.Entities.DTOs.RadLabResultDTOs
{
    public class RadLabResultDTO
    {
        public int Id { get; set; }
        public string ResultNote { get; set; }
        public int VisitRadLabTestId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public HealthFacilityDTOForOthers HealthFacility { get; set; }
        public ICollection<RadLabResultImageDTOForOthers> RadLabResultImages { get; set; }
    }
}
