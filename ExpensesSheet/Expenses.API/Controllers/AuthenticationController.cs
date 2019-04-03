using Expenses.Core.Application.Manager;
using Expenses.Core.Domain.Model;
using Expenses.Infrastructure.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Expenses.API.Controllers
{
    [EnableCors("http://localhost:4200", "*", "*")]
    [RoutePrefix("auth")]
    public class AuthenticationController : ApiController
    {
        private readonly IApplicationManager _applicationManager = CompositionRoot.Resolve<IApplicationManager>();

        [Route("login")]
        [HttpPost]
        public IHttpActionResult Login([FromBody]User user)
        {
            return null;
        }

        [Route("register")]
        [HttpPost]
        public IHttpActionResult Register([FromBody]User user)
        {
            try
            {
                var exists = _applicationManager.UserService.All().Any(u => u.UserName == user.UserName);
                if (exists) return BadRequest("User already exists");

                if (!_applicationManager.UserService.Add(user)) return BadRequest("User could not be added");

                return Ok(CreateToken(user));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private JwtPackage CreateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var claims = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Email, user.UserName),
            });

            const string secretKey = "key";
            var securityKey = new SymmetricSecurityKey(Encoding.Default.GetBytes(secretKey));
            var signInCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var token = (JwtSecurityToken)tokenHandler.CreateJwtSecurityToken(
                subject: claims,
                signingCredentials: signInCredentials);

            var tokenString = tokenHandler.WriteToken(token);

            return new JwtPackage()
            {
                UserName = user.UserName,
                Token = tokenString
            };

        }
    }
}


public class JwtPackage
{
    public string Token { get; set; }
    public string UserName { get; set; }
}