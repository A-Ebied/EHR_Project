using EHR_MVC.DTOs.GovernorateDTOs;
using EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Login;
using EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_MVC.DTOs.UserDataDTOs.MedicalDataDTOS;
using EHR_MVC.DTOs.UserDataDTOs.PersonalDataDTOs;
using System.Linq.Expressions;

namespace EHR_MVC.Repositories.Contracts
{
    public interface IAuthenService
    {
        Task<T> LoginAsync<T>(LoginRequestDTO login);
        Task<T> RegisterAsync<T>(RegistrationDataCreateDTO registration);

        Task<T> CreateUserPersonalDataAsync<T>(PersonalDataCreateDTO entity, string token = null);
        Task<T> DeleteUserPersonalDataAsync<T>(string id, string token = null);
        Task<T> UpdateUserPersonalDataAsync<T>(string id, PersonalDataUpdateDTO entity, string token = null); 
        
        Task<T> CreateUserMedicalDataAsync<T>(MedicalDataCreateDTO entity, string token = null);
        Task<T> DeleteUserMedicalDataAsync<T>(string id, string token = null);
        Task<T> UpdateUserMedicalDataAsync<T>(string id, MedicalDataUpdateDTO entity, string token = null);

        Task<T> GetHealthFacilityManagersAsync<T>(string token = null);
        Task<T> GetRolesAsync<T>(string token = null);
        Task<T> GetUserAsync<T>(string id, string token = null);
    }
}
