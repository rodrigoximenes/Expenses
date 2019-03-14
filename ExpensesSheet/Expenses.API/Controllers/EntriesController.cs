using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
