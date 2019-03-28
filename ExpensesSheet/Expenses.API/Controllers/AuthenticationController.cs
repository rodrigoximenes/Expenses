using Expenses.Core.Domain.Model;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Expenses.API.Controllers
{
    [EnableCors("http://localhost:4200", "*", "*")]
    [RoutePrefix("auth")]
    public class AuthenticationController : ApiController
    {
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
            return null;
        }

        private JwtPackage CreateToken(User user)
        {

        }
    }
}


public class JwtPackage
{
    public string Token { get; set; }
    public string UserName { get; set; }
}