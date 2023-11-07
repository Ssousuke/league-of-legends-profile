using LOLProfile.Application.DTO;

namespace LOLProfile.Application.Services.IServices
{
    public interface ISummonerService
    {
        public Task<SummonerDTO> GetSummonerAsync(string nickName);
    }
}
