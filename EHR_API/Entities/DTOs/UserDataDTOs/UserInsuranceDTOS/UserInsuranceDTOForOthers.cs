using System.ComponentModel;

namespace EHR_API.Entities.DTOs.UserDataDTOs
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
