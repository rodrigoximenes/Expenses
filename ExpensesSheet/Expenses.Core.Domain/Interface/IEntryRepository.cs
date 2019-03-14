using Expenses.Core.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Core.Domain.Interface
{
    public interface IEntryRepository : IBaseRepository<Entry>
    {
    }
}
