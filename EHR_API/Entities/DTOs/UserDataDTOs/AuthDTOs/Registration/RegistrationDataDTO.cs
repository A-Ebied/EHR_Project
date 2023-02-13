using EHR_API.Entities.DTOs.HealthFacilityDTOs;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration
{
    public class RegistrationDataDTO
    {
        public string Id { get; set; }
        public string IdType { get; set; }
        public string Nationality { get; set; }
        public string FullName { get; set; }
        public string UserName { get; init; }
        public string Password { get; init; }
        public string Email { get; init; }
        public string PhoneNumber { get; init; }

        public ICollection<string> Roles { get; init; }
        public HealthFacilityDTOForOthers HealthFacility { get; set; }
    }
}
