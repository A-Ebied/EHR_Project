using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Login;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Extensions;
using Microsoft.AspNetCore.Identity;
using System.Linq.Expressions;

namespace EHR_API.Repositories.Contracts
{
    public interface IAuthenticationRepository
    {
        Task<IdentityResult> RegisterUser(RegistrationDataCreateDTO registrationDataDTO);
        Task<RegistrationData> ValidateUser(LoginRequestDTO loginRequestDTO); 
        Task<string> CreateToken();

        Task<List<RegistrationData>> GetAllAsync(Expression<Func<RegistrationData, bool>> exception = null, string includeProperties = null, int pageNumber = 1, int pageSize = 0);
        Task<RegistrationData> GetAsync(Expression<Func<RegistrationData, bool>> exception, string includeProperties = null);
        Task<RegistrationData> UpdateAsync(RegistrationData entity);
    }
}
