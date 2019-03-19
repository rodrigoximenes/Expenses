using Expenses.Core.Application.Manager;
using Expenses.Core.Domain.Model;
using Expenses.Infrastructure.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Expenses.API.Controllers
{
    [EnableCors("http://localhost:4200", "*", "*")]
    public class EntriesController : ApiController
    {
        private readonly IApplicationManager  _applicationManager = CompositionRoot.Resolve<IApplicationManager>();

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

        [HttpGet]
        public IHttpActionResult GetEntry(int id)
        {
            try
            {
                Entry entry = _applicationManager.EntryService.FindById(id);
                if (entry == null) return NotFound();
                return Ok(entry);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        public IHttpActionResult PostEntry([FromBody]Entry entry)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (_applicationManager.EntryService.AddEntry(entry)) return Ok("Entry was created");

            return BadRequest();
        }

        [HttpPut]
        public IHttpActionResult UpdateEntry(int id, [FromBody]Entry newEntry)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != newEntry.Id) return BadRequest();

            try
            {
                Entry oldEntry = _applicationManager.EntryService.FindById(id);
                if (oldEntry == null) return NotFound();

                if (!_applicationManager.EntryService.UpdateEntry(oldEntry, newEntry)) return BadRequest();

                return Ok("Entry Updated");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IHttpActionResult DeleteEntry(int id)
        {
            try
            {
                var entryDeleted = _applicationManager.EntryService.FindById(id);
                if (entryDeleted == null) return NotFound();

                if (!_applicationManager.EntryService.RemoveEntry(entryDeleted)) return BadRequest();

                return Ok("Entry Deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
