using EHR_MVC.DTOs.AdmitDTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EHR_MVC.VM
{
    public class AdmitCreateVM
    {
        public AdmitCreateVM()
        {
            Admit = new();
        }

        public AdmitCreateDTO Admit { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> HealthFacilitiesList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> UsersList { get; set; }
    }
}
