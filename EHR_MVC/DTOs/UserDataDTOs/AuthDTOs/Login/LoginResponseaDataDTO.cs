using System.ComponentModel.DataAnnotations;

namespace EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Login
{
    public class LoginResponseaDataDTO
    {

        public string Nationality { get; set; }
        public string FullName { get; set; }
        public string UserName { get; init; }
        public string Email { get; init; }
    }
}
