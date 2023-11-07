using Microsoft.Extensions.Configuration;
using System.Text;

namespace LOLProfile.API.ZED.HttpService
{
    public class RiotHttpService : IRiotHttpService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;

        public RiotHttpService(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _config = config;
        }

        public RiotHttpService()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Accept-Language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/109.0.0.0 Safari/537.36");
            //  _httpClient.DefaultRequestHeaders.Add("Accept-Charset", "application/x-www-form-urlencoded; charset=UTF-8");
            _httpClient.DefaultRequestHeaders.Add("Origin", "https://developer.riotgames.com");
        }


        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            return await _httpClient.SendAsync(request);
        }
    }
}
