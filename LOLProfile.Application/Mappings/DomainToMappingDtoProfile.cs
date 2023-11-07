using AutoMapper;
using LOLProfile.Application.DTO;
using LOLProfile.Domain.Models;

namespace LOLProfile.Application.Mappings
{
    public class DomainToMappingDtoProfile : Profile
    {
        public DomainToMappingDtoProfile()
        {
            CreateMap<SummonerDTO, Summoner>().ReverseMap();
            CreateMap<LeagueDTO, League>().ReverseMap();
        }
    }
}
