using Expenses.Core.Application.Manager;
using Expenses.Core.Domain.Model;
using Expenses.Infrastructure.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Expenses.API.Controllers
{
    [EnableCors("http://localhost:4200","*","*")]
    public class EntriesController : ApiController
    {
        private readonly IApplicationManager _applicationManager = CompositionRoot.Resolve<IApplicationManager>();

        [HttpGet]
        public IHttpActionResult GetEntries()
        {
            try
            {
                IList<Entry> entries = _applicationManager.EntryService.All();

                return Ok(entries);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
