using System.ComponentModel;

namespace EHR_MVC.DTOs.UserDataDTOs.InsuranceDataDTOS
{
    public class InsuranceDataDTOForOthers
    {
        public string Id { get; set; }
        public bool HasGovernmentInsurance { get; set; }
        public bool HasAnotherInsurance { get; set; }
    }
}
