using LOLProfile.Domain.Interface;
using LOLProfile.Domain.Models;
using LOLProfile.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace LOLProfile.Infra.Data.Repository
{
    public class SummonerRepository : ISummonerRepository
    {
        private readonly ContextDb _context;

        public SummonerRepository(ContextDb context)
        {
            _context = context;
        }

        public async Task<Summoner> GetSummonerAsync(string nickName)
        {
            return await _context.Summoners.SingleOrDefaultAsync(x => x.Name.Equals(nickName));
        }
    }
}
