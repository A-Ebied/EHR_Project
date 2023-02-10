using EHR_API.Entities.DTOs.UserDataDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs;
using EHR_API.Extensions;
using Microsoft.AspNetCore.Identity;

namespace EHR_API.Repositories.Contracts
{
    public interface IAuthenticationRepository
    {
        Task<IdentityResult> RegisterUser(RegistrationDataDTO registrationDataDTO);
        Task<bool> ValidateUser(LoginRequestDTO loginRequestDTO); 
        Task<string> CreateToken();
    }
}
