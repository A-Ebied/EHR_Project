using EHR_MVC.Extensions;
using EHR_MVC.Models;
using EHR_MVC.Repositories.Contracts;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using static EHR_MVC.Extensions.SD;

namespace EHR_MVC.Repositories.Implementation
{
    public class BaseService : IBaseService
    {
        public APIResponse responseModel { get; set; }
        public IHttpClientFactory _clientFactory { get; set; }

        public BaseService(IHttpClientFactory clientFactory)
        {
            responseModel = new();
            _clientFactory = clientFactory;
        }
         
        public async Task<T> SendAsync<T>(APIRequest apiRequest)
        {
            try
            {
                var client = _clientFactory.CreateClient("EHRAPI");

                var message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiRequest.URL);
                if (apiRequest.Data != null)
                {
                    message.Content = new StringContent(
                        JsonConvert.SerializeObject(apiRequest.Data), 
                        Encoding.UTF8, 
                        "application/json");
                }

                message.Method = apiRequest.ApiType switch
                {
                    ApiType.POST => HttpMethod.Post,
                    ApiType.PUT => HttpMethod.Put,
                    ApiType.DELETE => HttpMethod.Delete,
                    _ => HttpMethod.Get,
                };

                if (!string.IsNullOrEmpty(apiRequest.Token))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiRequest.Token);
                }

                HttpResponseMessage apiResponse = await client.SendAsync(message);

                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                try
                {
                    APIResponse response = JsonConvert.DeserializeObject<APIResponse>(apiContent);
                    if (response != null)
                    {
                        if (apiResponse.StatusCode != System.Net.HttpStatusCode.OK && apiResponse.StatusCode != System.Net.HttpStatusCode.Created)
                        {
                            response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                            response.IsSuccess = false;
                            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(response));
                        }
                    }
                }
                catch (Exception)
                {
                    var exception = JsonConvert.DeserializeObject<T>(apiContent);
                    return exception;
                }

                var Response = JsonConvert.DeserializeObject<T>(apiContent);
                return Response;
            }
            catch (Exception ex)
            {
                return JsonConvert.DeserializeObject<T>(
                    JsonConvert.SerializeObject(
                        APIResponses.InternalServerError(ex)));
            }
        }
    }
}
