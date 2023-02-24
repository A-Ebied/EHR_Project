using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_API.Entities.DTOs.GovernorateDTOs;
using System.ComponentModel;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace EHR_API.Entities.DTOs.UserDataDTOs
{
    public class UserInsuranceDTO
    {
        public string InsuranceNo { get; set; }
        public string InsuranceType { get; set; }
        public string InsuranceOrganizationName { get; set; }
        public string RelationshipWithOrganization { get; set; }
        public string RegistrationDataId { get; set; }
    }
}
