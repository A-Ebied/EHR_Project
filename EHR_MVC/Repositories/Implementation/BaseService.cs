using EHR_MVC.Models;
using EHR_MVC.Repositories.Contracts;

namespace EHR_MVC.Repositories.Implementation
{
    public class BaseService : IBaseService
    {
        public BaseService()
        {
            responseModel = new();
        }

        public APIResponse responseModel { get; set; }

        public Task<T> SendAsync<T>(APIResponse apiResponse)
        {
            throw new NotImplementedException();
        }
    }
}
