using EHR_API.Entities.Models.UsersData;
using EHR_API.Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserDataDTOs
{
    public class UserInsuranceCreateDTO
    {
        [Required]
        public string InsuranceNo { get; set; }
        [Required]
        public string InsuranceType { get; set; }
        [Required]
        public string InsuranceOrganizationName { get; set; }
        [Required]
        public string RelationshipWithOrganization { get; set; }
        [Required]
        public string RegistrationDataId { get; set; }
    }
}
