using EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Registration;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EHR_MVC.VM
{
    public class RegistrationUpdateVM
    { 
        public RegistrationUpdateVM()
        {
            Register = new();
        }

        public RegistrationDataUpdateDTO Register { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> Roles { get; set; }
    
    }
}
