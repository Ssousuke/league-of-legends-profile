using AutoMapper;
using LOLProfile.Application.DTO;
using LOLProfile.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLProfile.Application.Services.IServices
{
    public class LeagueService : ILeagueService
    {
        private readonly ILeagueRepository _leagueRepository;
        private readonly IMapper _mapper;

        public LeagueService(ILeagueRepository leagueRepository, IMapper mapper)
        {
            _leagueRepository = leagueRepository;
            _mapper = mapper;
        }

        public async Task<List<LeagueDTO>> GetLeagueasync(string summonerId)
        {
            var league = await _leagueRepository.GetLeagueAsync(summonerId);
            return _mapper.Map<List<LeagueDTO>>(league);
        }
    }
}
