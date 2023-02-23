using EHR_MVC.DTOs.HealthFacilityDTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EHR_MVC.VM
{
    public class HealthFacilityUpdateVM
    {
        public HealthFacilityUpdateVM()
        {
            HealthFacility = new();
        }

        public HealthFacilityUpdateDTO HealthFacility { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> GovernoratesList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> ManagerList { get; set; }
    }
}
