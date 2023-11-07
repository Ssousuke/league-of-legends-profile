using LOLProfile.API.ZED.HttpService;
using LOLProfile.API.ZED.RestService.IRestService;
using LOLProfile.Application.DTO;
using LOLProfile.Application.Services.IServices;
using LOLProfile.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace LOLProfile.API.ZED.RestService
{
    public class LeagueRestService : ILeagueRestServices
    {
        private readonly ILeagueService _leagueServices;
        private readonly IRiotHttpService _httpService;
        private readonly IConfiguration _configuration;

        public LeagueRestService(ILeagueService leagueServices, IRiotHttpService httpService, IConfiguration configuration)
        {
            _leagueServices = leagueServices;
            _httpService = httpService;
            _configuration = configuration;
        }

        public async Task<List<LeagueDTO>> GetLeagueAsync(string summonerId)
        {
            var league = await _leagueServices.GetLeagueasync(summonerId);

            if (!league.Any())
            {
                HttpRequestMessage request = new HttpRequestMessage();
                request.Method = HttpMethod.Get;
                request.Headers.Add("X-Riot-Token", _configuration.GetSection("XRiotToken").Value.ToString());
                request.RequestUri = new Uri($"{_configuration.GetSection("LeagueUrl").Value}/{summonerId}");

                using (HttpResponseMessage response = await _httpService.SendAsync(request))
                {
                    string contentResponse = await response.Content.ReadAsStringAsync();
                    var json = JsonSerializer.Deserialize<List<LeagueDTO>>(contentResponse);

                    if (response.IsSuccessStatusCode)
                    {
                        var leagueData = json;
                        return leagueData;
                    }
                }
            }

            return league;
        }
    }
}
