using Microsoft.AspNetCore.Mvc;
using msvHarmony.Domain.Models.Identity;
using msvHarmony.Domain.Ports;

namespace CleanArchitecture.API.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<AuthResponse>> LoginAsync([FromBody] AuthRequest request)
        {
            return Ok(await _authService.LoginAsync(request));
        }

        [HttpPost("register")]
        public async Task<ActionResult<RegistrationResponse>> RegisterAsync([FromBody] RegistrationRequest request)
        {
            return Ok(await _authService.RegisterAsync(request));
        }

        [HttpPost("forgot")]
        public async Task<ActionResult> ForgotPasswordAsync([FromBody] ForgotPasswordRequest request)
        {
            await _authService.ForgotPasswordAsync(request);

            return Ok();
        }

        [HttpPost("reset")]
        public async Task<ActionResult> ResetPasswordAsync([FromBody] ResetPasswordRequest request)
        {
            await _authService.ResetPasswordAsync(request);

            return Ok();
        }

    }
}
