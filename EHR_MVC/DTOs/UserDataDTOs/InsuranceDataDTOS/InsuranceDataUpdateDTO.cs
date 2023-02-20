using System.ComponentModel.DataAnnotations;

namespace EHR_MVC.DTOs.UserDataDTOs.InsuranceDataDTOS
{
    public class InsuranceDataUpdateDTO
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public bool HasGovernmentInsurance { get; set; }
        [Required]
        public bool HasAnotherInsurance { get; set; }
    }
}
