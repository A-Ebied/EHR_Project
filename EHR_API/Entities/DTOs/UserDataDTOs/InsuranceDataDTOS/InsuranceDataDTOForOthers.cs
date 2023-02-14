using System.ComponentModel;

namespace EHR_API.Entities.DTOs.UserDataDTOs
{
    public class InsuranceDataDTOForOthers
    {
        public string Id { get; set; }
        public bool HasGovernmentInsurance { get; set; }
        public bool HasAnotherInsurance { get; set; }
    }
}
