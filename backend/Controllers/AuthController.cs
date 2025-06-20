using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.Interfaces;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromForm] User user)
        {
            if (_userService.ValidateUser(user))
                return Ok("Login Success");

            return Unauthorized("Invalid Credentials");
        }
    }
}