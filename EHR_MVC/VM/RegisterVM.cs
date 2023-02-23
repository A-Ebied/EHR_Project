using EHR_MVC.DTOs.HealthFacilityDTOs;
using EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Registration;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EHR_MVC.VM
{
    public class RegisterVM
    {
        public RegisterVM()
        {
            Register = new();
        }

        public RegistrationDataCreateDTO Register { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> Roles { get; set; }
    }
}
