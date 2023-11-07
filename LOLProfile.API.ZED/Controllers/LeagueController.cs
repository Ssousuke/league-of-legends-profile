using LOLProfile.API.ZED.RestService.IRestService;
using LOLProfile.Application.Services.IServices;
using LOLProfile.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LOLProfile.API.ZED.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeagueController : ControllerBase
    {
        private readonly ILeagueRestServices _leagueRestServices;

        public LeagueController(ILeagueRestServices leagueRestServices)
        {
            _leagueRestServices = leagueRestServices;
        }

        [HttpGet("buscar-perfil/{summonerId}")]
        public async Task<IActionResult> GetSummonerAsync(string summonerId)
        {
            var leagues = await _leagueRestServices.GetLeagueAsync(summonerId);
            if (leagues is null)
                return BadRequest("Não foi possível completar a requisição.");
            return Ok(leagues);
        }
    }
}
