using LOLProfile.API.ZED.HttpService;
using LOLProfile.API.ZED.RestService.IRestService;
using LOLProfile.Application.DTO;
using LOLProfile.Application.Services.IServices;
using System.Text.Json;

namespace LOLProfile.API.ZED.RestService
{
    public class SummonerRestServices : ISummonerRestServices
    {
        private readonly ISummonerService _summonerService;
        private readonly IRiotHttpService _httpService;
        private readonly IConfiguration _configuration;

        public SummonerRestServices(ISummonerService summonerService, IRiotHttpService httpService, IConfiguration configuration)
        {
            _summonerService = summonerService;
            _httpService = httpService;
            _configuration = configuration;
        }

        public async Task<SummonerDTO> GetSummonerAsync(string nickName)
        {
            var summoner = await _summonerService.GetSummonerAsync(nickName);

            if (summoner is null)
            {
                HttpRequestMessage request = new HttpRequestMessage();
                request.Method = HttpMethod.Get;
                request.Headers.Add("X-Riot-Token", _configuration.GetSection("XRiotToken").Value.ToString());
                request.RequestUri = new Uri($"{_configuration.GetSection("RiotSummonerUrL").Value}/{nickName}");

                using (HttpResponseMessage response = await _httpService.SendAsync(request))
                {
                    string contentResponse = await response.Content.ReadAsStringAsync();
                    SummonerDTO? json = JsonSerializer.Deserialize<SummonerDTO>(contentResponse);

                    if (response.IsSuccessStatusCode)
                    {
                        SummonerDTO? summonerResquest = json;
                        return summonerResquest;
                    }
                }
            }
            return summoner;
        }
    }
}
