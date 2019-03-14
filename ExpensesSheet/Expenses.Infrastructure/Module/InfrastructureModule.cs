using Expenses.Core.Domain.Interface;
using Expenses.Infrastructure.Context;
using Expenses.Infrastructure.Repository;
using Ninject.Modules;

namespace Expenses.Infrastructure.Module
{
    public class InfrastructureModule : NinjectModule
    {
        public override void Load()
        {
            //Contexto
            Bind<ExpensesContext>().ToSelf().InTransientScope();

            //Repositorio
            this.Bind<IEntryRepository>().To<EntryRepository>();
            this.Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>));
        }
    }
}
