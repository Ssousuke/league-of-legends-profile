using LOLProfile.Domain.Interface;
using LOLProfile.Domain.Models;
using LOLProfile.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLProfile.Infra.Data.Repository
{
    public class LeagueRepository : ILeagueRepository
    {
        private readonly ContextDb _context;

        public LeagueRepository(ContextDb context)
        {
            _context = context;
        }

        public async Task<List<League>> GetLeagueAsync(string summonerId)
        {
            return await _context.Leagues.Where(x => x.SummonerId.Equals(summonerId)).ToListAsync();
        }
    }
}
