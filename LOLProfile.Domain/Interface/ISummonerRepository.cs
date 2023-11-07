using LOLProfile.Domain.Models;

namespace LOLProfile.Domain.Interface
{
    public interface ISummonerRepository
    {
        public Task<Summoner> GetSummonerAsync(string nickName);
    }
}
