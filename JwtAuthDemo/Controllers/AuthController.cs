using JwtAuthDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ITokenService _tokenService;

        public AuthController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request.Username == "admin" && request.Password == "admin")
            {
                // If the user is an admin, generate JWT Token
                var token = _tokenService.GenerateToken(request.Username, new List<string> { "Admin" });
                return Ok(new { token });
            }

            return Unauthorized("Unvalid username or password");
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
