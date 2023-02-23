using EHR_MVC.DTOs.GovernorateDTOs;
using EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Login;
using EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Registration;
using System.Linq.Expressions;

namespace EHR_MVC.Repositories.Contracts
{
    public interface IAuthenService
    {
        Task<T> LoginAsync<T>(LoginRequestDTO login);
        Task<T> RegisterAsync<T>(RegistrationDataCreateDTO registration);
        Task<T> GetHealthFacilityManagersAsync<T>(string token = null);
        Task<T> GetRolesAsync<T>(string token = null);
    }
}
