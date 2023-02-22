using EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Login;
using EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_MVC.Repositories.Contracts;
using static EHR_MVC.Extensions.SD;

namespace EHR_MVC.Repositories.Implementation
{
    public class AuthenService : BaseService, IAuthenService
    {
        private string _url;

        public AuthenService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory) 
        {
            _url = configuration.GetValue<string>("URLs:EHRAPI");
        }

        public Task<T> LoginAsync<T>(LoginRequestDTO login)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.POST,
                Data = login,
                URL = $"{_url}/api/AuthenticationAPI/Login"
            });
        }

        public Task<T> RegisterAsync<T>(RegistrationDataCreateDTO registration)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.POST,
                Data = registration,
                URL = $"{_url}/api/AuthenticationAPI/RegisterUser"
            });
        }
    }
}
