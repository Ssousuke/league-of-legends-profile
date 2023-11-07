using LOLProfile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLProfile.Domain.Interface
{
    public interface ILeagueRepository
    {
        public Task<League> GetLeagueAsync(string summonerId);
    }
}
