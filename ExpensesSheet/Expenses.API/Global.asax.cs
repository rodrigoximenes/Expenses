using Expenses.Core.Application.Module;
using Expenses.Infrastructure.DependencyInjection;
using Expenses.Infrastructure.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Expenses.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            CompositionRoot.Init();
            CompositionRoot.AddModule(new InfrastructureModule());
            CompositionRoot.AddModule(new ApplicationModule());
        }
    }
}
