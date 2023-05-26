using GolfScore.Services;
using GolfScore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GolfScore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : BaseController
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult GetEmojiKeypad()
        {
            return HandleRequest(() => { return AuthService.GetEmojiKeypad; });
        }
    }
}
