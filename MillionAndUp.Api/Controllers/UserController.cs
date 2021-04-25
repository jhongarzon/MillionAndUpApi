using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MillionAndUp.Api.Helpers;
using MillionAndUp.Domain.Models;
using MillionAndUp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MillionAndUp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        private readonly IJwtAuthManager _jwtAuthManager;

        public UsersController(IUserService userService, IJwtAuthManager jwtAuthManager)
        {
            _userService = userService;
            _jwtAuthManager = jwtAuthManager;
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]
        public IActionResult Authenticate(AuthenticateRequest model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });


            var claims = new[]
            {
                new Claim(ClaimTypes.Name,model.Username),
            };

            var jwtResult = _jwtAuthManager.GenerateTokens(model.Username, claims, DateTime.Now);
            response.Token = jwtResult.AccessToken;
            return Ok(response);
        }
        [HttpGet("user")]
        public ActionResult GetCurrentUser()
        {
            return Ok(new AuthenticateResponse
            {
                Username = User.Identity?.Name,
                FirstName = User.FindFirst("FirstName")?.Value
            });
        }
        [HttpPost("logout")]
        public ActionResult Logout()
        {

            var userName = User.Identity?.Name;
            _jwtAuthManager.RemoveRefreshTokenByUserName(userName);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}
