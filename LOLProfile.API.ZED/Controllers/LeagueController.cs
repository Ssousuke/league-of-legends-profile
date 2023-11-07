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
        private readonly ILeagueService _serviceServices;

        public LeagueController(ILeagueService serviceServices)
        {
            _serviceServices = serviceServices;
        }
    }
}
