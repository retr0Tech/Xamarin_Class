using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TestApp.Models;

namespace TestApp.Services
{
    public class ApiService : IApiService
    {
        public ApiService()
        {
        }

        public async Task<Users> GetRate()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://api.onupkeep.com/api/v2/users/");
            return JsonConvert.DeserializeObject<Users>(response);
        }

    }
}
