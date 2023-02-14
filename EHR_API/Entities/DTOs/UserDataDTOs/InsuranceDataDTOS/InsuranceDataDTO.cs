using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_API.Entities.DTOs.GovernorateDTOs;
using System.ComponentModel;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Entities.Models;

namespace EHR_API.Entities.DTOs.UserDataDTOs
{
    public class InsuranceDataDTO
    {
        public string Id { get; set; }
        public bool HasGovernmentInsurance { get; set; }
        public bool HasAnotherInsurance { get; set; }
        
        [DisplayName("Created at")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Updated at")]
        public DateTime UpdateddAt { get; set; }

        public ICollection<UserInsuranceDTOForOthers> UserInsurances { get; set; }
    }
}
