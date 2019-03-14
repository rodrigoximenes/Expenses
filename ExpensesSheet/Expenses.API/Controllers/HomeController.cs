using Expenses.Core.Application.Manager;
using Expenses.Infrastructure.DependencyInjection;
using System.Web.Mvc;

namespace Expenses.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplicationManager _applicationManager = CompositionRoot.Resolve<IApplicationManager>();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
