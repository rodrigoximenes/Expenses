using Expenses.Infrastructure.Context;
using Ninject.Modules;

namespace Expenses.Infrastructure.Module
{
    public class InfrastructureModule : NinjectModule
    {
        public override void Load()
        {
            //Contexto
            Bind<ExpensesContext>().ToSelf().InTransientScope();

        }
    }
}
