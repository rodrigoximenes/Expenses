using System.Web.Http;

namespace Expenses.API.Controllers
{
    public class EntriesController : ApiController
    {

        public IHttpActionResult GetEntries()
        {
            return Ok();
        }
    }
}
