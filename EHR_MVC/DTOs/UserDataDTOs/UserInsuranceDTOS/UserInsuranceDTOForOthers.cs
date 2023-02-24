using System.ComponentModel;

namespace EHR_MVC.DTOs.UserDataDTOs.UserInsuranceDTOS
{
    public class UserInsuranceDTOForOthers
    {
        public string InsuranceNo { get; set; }
        public string InsuranceType { get; set; }
        public string InsuranceOrganizationName { get; set; }
        public string RelationshipWithOrganization { get; set; }
        public string RegistrationDataId { get; set; }
    }
}
