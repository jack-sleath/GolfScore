using GolfScore.Models.Request;
using GolfScore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GolfScore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : BaseController
    {
        private readonly IMatchService _matchService;
        public MatchController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        [HttpPost]
        public IActionResult CreateMatch(CreateMatchRequest request)
        {
            return HandleCreate(() => _matchService.CreateMatch(request));
        }
    }
}
