namespace Expenses.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Expenses.Infrastructure.Context;
    using Core.Domain.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<ExpensesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ExpensesContext context)
        {
            context.Entries.Add(new Entry()
            {
                Description = "Teste",
                IsExpense = false,
                Value = 10
            });
        }
    }
}
