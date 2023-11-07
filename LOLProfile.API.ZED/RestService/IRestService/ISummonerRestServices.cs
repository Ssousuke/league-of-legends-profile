using LOLProfile.Application.DTO;

namespace LOLProfile.API.ZED.RestService.IRestService
{
    public interface ISummonerRestServices
    {
        public Task<SummonerDTO> GetSummonerAsync(string nickName);
    }
}
