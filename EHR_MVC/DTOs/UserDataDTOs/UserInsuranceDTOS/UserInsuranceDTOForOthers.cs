using System.ComponentModel;

namespace EHR_MVC.DTOs.UserDataDTOs.UserInsuranceDTOS
{
    public class UserInsuranceDTOForOthers
    {
        public int Id { get; set; }
        public string InsuranceNo { get; set; }
        public string InsuranceOrganizationName { get; set; }
        public string RelationshipWithOrganization { get; set; }
        public string InsuranceType { get; set; }
    }
}
