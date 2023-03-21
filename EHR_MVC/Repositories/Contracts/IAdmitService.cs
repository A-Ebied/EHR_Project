using EHR_MVC.DTOs.AdmitDTOs;

namespace EHR_MVC.Repositories.Contracts
{
    public interface IAdmitService
    {
        Task<T> GetUserAdmits<T>(string userId, string token = null);
        Task<T> GetAsync<T>(int id, string token = null);
        Task<T> CreateAsync<T>(AdmitCreateDTO entity, string token = null);
        Task<T> UpdateAsync<T>(AdmitUpdateDTO entity, string token = null);
        Task<T> DeleteAsync<T>(int id, string token = null);
    }
}
