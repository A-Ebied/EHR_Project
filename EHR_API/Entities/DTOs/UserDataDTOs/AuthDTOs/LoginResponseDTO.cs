using EHR_API.Entities.Models.UsersData;
using Microsoft.AspNetCore.Identity;

namespace EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs
{
    public class LoginResponseDTO
    {
        public LoginResponseaDataDTO User { get; set; }
        public ICollection<string> Roles { get; init; }
        public string Token { get; set; }
    }
}
