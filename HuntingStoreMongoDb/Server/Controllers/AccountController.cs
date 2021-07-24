using HuntingStoreMongoDb.Server.Repositories;
using HuntingStoreMongoDb.Shared.IdentityModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HuntingStoreMongoDb.Server.Controllers
{
    
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IConfiguration _configuration;
        private readonly UserRepository _userRepository;

        public AccountController(ILogger<AccountController> logger, IConfiguration configuration, UserRepository userRepository)
        {
            _logger = logger;
            _configuration = configuration;
            _userRepository = userRepository;
        }

        [HttpPost]
        [Route("Account/LoginAsync")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginModel loginModel)
        {
            try
            {
                _logger.LogWarning("Try log");
                var user = await _userRepository.AuthenticateAsync(loginModel.UserName, loginModel.Password);
                if (user == null)
                    return Unauthorized();

                JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                byte[] secret = Encoding.ASCII.GetBytes(_configuration["jwtSecret"]);

                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, loginModel.UserName)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTimeOffset.UtcNow.AddHours(24),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity), authProperties);

                SecurityTokenDescriptor descriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(claims),
                    Expires = DateTime.UtcNow.AddHours(24),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secret), SecurityAlgorithms.HmacSha256Signature)
                };

                SecurityToken token = handler.CreateToken(descriptor);

                _logger.LogWarning("User is logged");

                var userToken = handler.WriteToken(token);

                return Ok(userToken);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        [Route("Account/GetCurrentUser")]
        public CurrentUser GetCurrentUser()
        {
            try
            {
                return new CurrentUser
                {
                    IsAuthenticated = User.Identity.IsAuthenticated,
                    UserName = User.Identity.Name,
                    Claims = User.Claims
                        .ToDictionary(c => c.Type, c => c.Value)
                };

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new CurrentUser();
            }
        }

        [Authorize]
        [HttpPost]
        [Route("Account/Logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            _logger.LogWarning("user logged out");
            return Ok();
        }
    }
}
