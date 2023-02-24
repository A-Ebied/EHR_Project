using EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Login;
using EHR_MVC.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_MVC.DTOs.UserDataDTOs.PersonalDataDTOs;
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

        public Task<T> CreateUserPersonalDataAsync<T>(PersonalDataCreateDTO entity, string token = null)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.POST,
                Data = entity,
                URL = $"{_url}/api/PersonalDataAPI/CreateUserPersonalData",
                Token = token
            });
        }

        public Task<T> DeleteUserPersonalDataAsync<T>(string id, string token = null)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.DELETE,
                URL = $"{_url}/api/PersonalDataAPI/{id}",
                Token = token
            });
        }

        public Task<T> GetHealthFacilityManagersAsync<T>(string token = null)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.GET,
                URL = $"{_url}/api/AuthenticationAPI/GetHealthFacilityManagers",
                Token = token
            });
        }

        public Task<T> GetRolesAsync<T>(string token = null)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.GET,
                URL = $"{_url}/api/AuthenticationAPI/GetRoles",
                Token = token
            });
        }

        public Task<T> GetUserAsync<T>(string id, string token = null)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = ApiType.GET,
                URL = $"{_url}/api/AuthenticationAPI/{id}",
                Token = token
            });
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
