using LOLProfile.Application.DTO;
using LOLProfile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLProfile.Application.Services.IServices
{
    public interface ILeagueService
    {
        public Task<LeagueDTO> GetLeagueasync(string summonerId);
    }
}
