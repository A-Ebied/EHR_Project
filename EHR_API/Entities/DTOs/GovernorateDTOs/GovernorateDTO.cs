using EHR_API.Entities.DTOs.HealthFacilityDTOs;

namespace EHR_API.Entities.DTOs.GovernorateDTOs
{
    public class GovernorateDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<HealthFacilityDTOForOthers> HealthFacilitys { get; set; }
    }
}
