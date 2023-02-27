using EHR_API.Entities.DTOs.HealthFacilityDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs;

namespace EHR_API.Entities.DTOs.GovernorateDTOs
{
    public class GovernorateDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateddAt { get; set; }

        public ICollection<HealthFacilityDTOForOthers> HealthFacilitys { get; set; }
        public ICollection<UserDTOForOthers> Users { get; set; }
    }
}
