using Expenses.Core.Domain.Interface;
using Expenses.Core.Domain.Model;
using Expenses.Infrastructure.Context;

namespace Expenses.Infrastructure.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly ExpensesContext context;

        public UserRepository(ExpensesContext context) : base(context)
        {
            this.context = context;
        }
    }
}
