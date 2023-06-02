using System.Text.Json;
using System.Text;
using EHR_API.Entities.Models;

namespace EHR_API.Extensions
{
    public static class SD
    {
        public const string SystemManager  = "SystemManager";
        public const string HealthFacilityManager = "HealthFacilityManager";
        public const string Physician = "Physician";
        public const string Technician = "Technician";
        public const string Pharmacist = "Pharmacist";
        public const string Patient = "Patient";


        public const string ProfileName = "DefCache";

        public static async Task<string> MLAPIPneumoniaModelAsync(string imgUrl)
        {
            try
            {
                HttpClient _httpClient = new HttpClient();
                JsonSerializerOptions _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                var newUrl = imgUrl.Replace("/", "\\");
                var url = new ImgUrl
                {
                    URL = @"D:\0_MY_DATA\2_IT\Level_4\IT Project\Project\Backend\##With new features\EHR_Project\EHR_API\wwwroot" + newUrl
                };

                string URL = JsonSerializer.Serialize(url);
                StringContent requestContent = new StringContent(URL, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("http://localhost:8000/PneumoniaPredict", requestContent);

                response.EnsureSuccessStatusCode();
                var is_normal = await response.Content.ReadAsStringAsync();


                return is_normal;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
