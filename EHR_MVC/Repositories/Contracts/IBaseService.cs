using EHR_MVC.Models;

namespace EHR_MVC.Repositories.Contracts
{
    public interface IBaseService
    {
        APIResponse responseModel { get; set; }
        Task<T> SendAsync<T>(APIResponse apiResponse);
    }
}
