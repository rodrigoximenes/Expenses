using Expenses.Core.Application.Manager;
using Ninject.Modules;

namespace Expenses.Core.Application.Module
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            KernelInstance.Bind<IApplicationManager>().To<ApplicationManager>();
        }
    }
}
