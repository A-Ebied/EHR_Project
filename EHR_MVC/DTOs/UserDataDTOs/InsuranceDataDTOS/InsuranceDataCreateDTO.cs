using System.ComponentModel.DataAnnotations;
using EHR_MVC.DTOs.UserDataDTOs.UserInsuranceDTOS;

namespace EHR_MVC.DTOs.UserDataDTOs.InsuranceDataDTOS
{
    public class InsuranceDataCreateDTO
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public bool HasGovernmentInsurance { get; set; }
        [Required]
        public bool HasAnotherInsurance { get; set; }
        public UserInsurancesCreateDTO UserInsurancesCreateDTO { get; set; }
    }
}
