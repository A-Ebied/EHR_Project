using EHR_API.Entities.DTOs.HealthFacilityDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs;
using System.ComponentModel;

namespace EHR_API.Entities.DTOs.GovernorateDTOs
{
    public class GovernorateDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DisplayName("Created at")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Updated at")]
        public DateTime UpdateddAt { get; set; }

        public ICollection<HealthFacilityDTOForOthers> HealthFacilitys { get; set; }
        public ICollection<PersonalDataDTOForOthers> PersonalData { get; set; }
    }
}
