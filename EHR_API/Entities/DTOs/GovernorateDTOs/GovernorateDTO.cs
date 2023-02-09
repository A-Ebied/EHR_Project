using EHR_API.Entities.Models;

namespace EHR_API.Entities.DTOs.GovernorateDTOs
{
    public class GovernorateDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public ICollection<HealthFacility>? HealthFacilitys { get; set; }
    }
}
