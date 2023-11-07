using AutoMapper;
using LOLProfile.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLProfile.Application.Services.IServices
{
    public class LeagueService : ILeagueService
    {
        private readonly ILeagueService _leagueService;
        private readonly IMapper _mapper;

        public LeagueService(ILeagueService leagueService, IMapper mapper)
        {
            _leagueService = leagueService;
            _mapper = mapper;
        }

        public async Task<LeagueDTO> GetLeagueasync(string summonerId)
        {
            var league = await _leagueService.GetLeagueasync(summonerId);
            return _mapper.Map<LeagueDTO>(league);
        }
    }
}
