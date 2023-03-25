using EHR_API.Entities.DTOs.HealthFacilityDTOs;

namespace EHR_API.Entities.DTOs.RadLabResultDTOs
{
    public class RadLabResultDTOForOthers
    {
        public int Id { get; set; }
        public HealthFacilityDTOForOthers HealthFacility { get; set; }
    }
}
