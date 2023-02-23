using EHR_MVC.DTOs.HealthFacilityDTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EHR_MVC.VM
{
    public class HealthFacilityCreateVM
    {
        public HealthFacilityCreateVM()
        {
            HealthFacility = new();
        }

        public HealthFacilityCreateDTO HealthFacility { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> GovernoratesList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> ManagerList { get; set; }
    }
}
