using Expenses.Core.Application.Manager;
using Expenses.Core.Application.Services;
using Expenses.Core.Application.Services.Interface;
using Ninject.Modules;

namespace Expenses.Core.Application.Module
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            //Manager
            KernelInstance.Bind<IApplicationManager>().To<ApplicationManager>();

            //Services
            KernelInstance.Bind<IEntryService>().To<EntryService>();
        }
    }
}
