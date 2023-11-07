using LOLProfile.API.ZED.HttpService;
using LOLProfile.API.ZED.RestService.IRestService;
using LOLProfile.Application.DTO;
using LOLProfile.Application.Services.IServices;
using LOLProfile.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Text.Json;

namespace LOLProfile.API.ZED.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SummonerController : ControllerBase
    {
        private readonly ISummonerRestServices _service;

        public SummonerController(ISummonerRestServices service)
        {
            _service = service;
        }

        [HttpGet("buscar-invocador/{nickName}")]
        public async Task<IActionResult> GetSummonerAsync(string nickName)
        {
            var summoner = await _service.GetSummonerAsync(nickName);
            if (summoner is null)
                return BadRequest("Não foi possível completar a requisição.");

            return Ok(summoner);
        }
    }
}
