using LOLProfile.Application.DTO;

namespace LOLProfile.API.ZED.RestService.IRestService
{
    public interface ILeagueRestServices
    {
        public Task<List<LeagueDTO>> GetLeagueAsync(string summonerId);
    }
}
