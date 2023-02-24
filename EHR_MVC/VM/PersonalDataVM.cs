using EHR_MVC.DTOs.UserDataDTOs.PersonalDataDTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EHR_MVC.VM
{
    public class PersonalDataVM
    { 
        public PersonalDataVM()
        {
            PersonalData = new();
        }

        public PersonalDataCreateDTO PersonalData { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> GovernoratesList { get; set; }
    }
}
