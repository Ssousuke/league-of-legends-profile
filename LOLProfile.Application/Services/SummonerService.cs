using AutoMapper;
using LOLProfile.Application.DTO;
using LOLProfile.Application.Services.IServices;
using LOLProfile.Domain.Interface;

namespace LOLProfile.Application.Services
{
    public class SummonerService : ISummonerService
    {
        private readonly ISummonerRepository _summonerRepository;
        private readonly IMapper _mapper;

        public SummonerService(ISummonerRepository summonerRepository, IMapper mapper)
        {
            _summonerRepository = summonerRepository;
            _mapper = mapper;
        }

        public async Task<SummonerDTO> GetSummonerAsync(string nickName)
        {
            var summoner = await _summonerRepository.GetSummonerAsync(nickName);
            return _mapper.Map<SummonerDTO>(summoner);
        }
    }
}
