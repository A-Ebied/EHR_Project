using System.ComponentModel;
using EHR_MVC.DTOs.UserDataDTOs.UserInsuranceDTOS;

namespace EHR_MVC.DTOs.UserDataDTOs.InsuranceDataDTOS
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
