using EHR_MVC.DTOs.GovernorateDTOs;
using EHR_MVC.DTOs.UserDataDTOs.UserInsuranceDTOS;
using System.Linq.Expressions;

namespace EHR_MVC.Repositories.Contracts
{
    public interface IUserInsuranceService
    {
        Task<T> GetAllAsync<T>(string token = null);
        Task<T> GetUserInsurancesAsync<T>(string id, string token = null);
        Task<T> GetInsuranceAsync<T>(int id, string token = null);
        Task<T> CreateAsync<T>(UserInsuranceCreateDTO entity, string token = null);
        Task<T> UpdateAsync<T>(UserInsuranceUpdateDTO entity, string token = null);
        Task<T> DeleteAsync<T>(int id, string token = null);
    }
}
