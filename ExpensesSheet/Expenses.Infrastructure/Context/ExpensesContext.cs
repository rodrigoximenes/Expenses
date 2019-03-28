using Expenses.Core.Domain.Model;
using System.Data.Entity;

namespace Expenses.Infrastructure.Context
{
    public class ExpensesContext : DbContext
    {
        public DbSet<Entry> Entries { get; set; }
        public DbSet<User> Users { get; set; }

        public ExpensesContext() : base("name = ExpensesDb")
        {

        }
    }
}
