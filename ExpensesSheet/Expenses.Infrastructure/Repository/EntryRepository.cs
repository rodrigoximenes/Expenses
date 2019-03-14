using Expenses.Core.Domain.Interface;
using Expenses.Core.Domain.Model;
using Expenses.Infrastructure.Context;

namespace Expenses.Infrastructure.Repository
{
    public class EntryRepository : BaseRepository<Entry>, IEntryRepository
    {
        private readonly ExpensesContext context;

        public EntryRepository(ExpensesContext context) : base(context)
        {
            this.context = context;
        }
    }
}
