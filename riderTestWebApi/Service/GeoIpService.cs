using System.Net.Http;
using System.Threading.Tasks;

namespace riderTestWebApi.Service
{
    public class GeoIpService : IGeoIpService
    {
        private readonly IHttpClientFactory _httpClient;
        private string GeoIpUrl => "https://api.ipify.orrrrg?format=json";

        public GeoIpService(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetCurrentIpAsync()
        {
            var httpClient = _httpClient.CreateClient();
            var result = await httpClient.GetAsync("https://api.ipify.org11?format=json");
            result.EnsureSuccessStatusCode();
            var currentIp = await result.Content.ReadAsStringAsync();
            return currentIp;
        }
    }
}