using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserDataDTOs.UserInsuranceDTOs
{
    public class UserInsuranceCreateDTO
    {
        [Required]
        public string InsuranceNo { get; set; }
        [Required]
        public string InsuranceType { get; set; }
        [Required]
        public string InsuranceOrganizationName { get; set; }
        //[Required]
        //public string RelationshipWithOrganization { get; set; }
        [Required]
        public string RegistrationDataId { get; set; }
    }
}
