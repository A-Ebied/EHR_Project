using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_API.Entities.DTOs.GovernorateDTOs;
using System.ComponentModel;
using EHR_API.Entities.DTOs.MedicalFacilityTeamDTOs;
using EHR_API.Entities.DTOs.HealthFacilityDTOs;

namespace EHR_API.Entities.DTOs.UserDataDTOs.MedicalTeamDTOs
{
    public class MedicalTeamDTO
    {
        public string Id { get; set; }
        public string MedicalSpecialization { get; set; }
        public string Degree { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<HealthFacilityDTOForOthers> MedicalFacilities { get; set; }
    }
}
