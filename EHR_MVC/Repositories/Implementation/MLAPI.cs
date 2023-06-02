using EHR_MVC.Repositories.Contracts;
using System.Text;

using EHR_MVC.Entities.Models;
using System.Text.Json;

namespace EHR_MVC.Repositories.Implementation
{
    public class MLAPI : IMLAPI
    {
        private readonly IWebHostEnvironment _webHost;

        public MLAPI(IWebHostEnvironment webHost)
        {
            _webHost = webHost;
        }

        public async Task<string> SendAsync(string imgUrl)
        {
            try
            {
                HttpClient _httpClient = new HttpClient();
                JsonSerializerOptions _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                var newUrl = imgUrl.Replace("/", "\\" );
                var url = new ImgUrl
                {
                    URL = @"D:\0_MY_DATA\2_IT\Level_4\IT Project\Project\Backend\##With new features\EHR_Project\EHR_API\wwwroot" + newUrl
                };

                string URL = JsonSerializer.Serialize(url);
                StringContent requestContent = new StringContent(URL, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("http://localhost:8000/PneumoniaPredict", requestContent);

                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();

                


                //var client = _clientFactory.CreateClient("EHRAPI");

                var message = new HttpRequestMessage();
                //message.Headers.Add("Accept", "application/json");
                //message.RequestUri = new Uri("http://localhost:8000");

                //object temp = new { URL = imgUrl};
                //message.Content = message.Content = new StringContent(
                //         JsonConvert.SerializeObject(new { URL = imgUrl }),
                //         Encoding.UTF8,
                //         "application/json");


                //message.Method =  HttpMethod.Get;
  
                //HttpResponseMessage apiResponse = await client.SendAsync(message);
                //var apiContent = await apiResponse.Content.ReadAsStringAsync();
                //try
                //{
                //    //APIResponse response = JsonConvert.DeserializeObject<APIResponse>(apiContent);
                //    //if (response != null)
                //    //{
                //    //    if (apiResponse.StatusCode != System.Net.HttpStatusCode.OK && apiResponse.StatusCode != System.Net.HttpStatusCode.Created)
                //    //    {
                //    //        response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                //    //        response.IsSuccess = false;
                //    //        return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(response));
                //    //    }
                //    //}
                //}
                //catch (Exception exception)
                //{
                   
                //    return exception.Message;
                //}

                return "null";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}

