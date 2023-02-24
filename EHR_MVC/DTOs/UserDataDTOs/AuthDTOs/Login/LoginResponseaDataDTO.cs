using System.ComponentModel.DataAnnotations;

namespace EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Login
{
    public class LoginResponseaDataDTO
    {

        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Nationality { get; set; }
    }
}
