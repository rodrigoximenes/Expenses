using Expenses.Infrastructure.Module;
using Ninject;

namespace Expenses.Infrastructure.NinjectConfig
{
    public static class ExpensesKernel
    {
        private readonly static IKernel _kernel = new StandardKernel(new InfrastructureModule());

        public static TEntity GetInstance<TEntity>()
        {
            return _kernel.Get<TEntity>();
        }
    }
}
