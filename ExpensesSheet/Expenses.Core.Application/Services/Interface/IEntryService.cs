using Expenses.Core.Domain.Model;
using System.Collections.Generic;

namespace Expenses.Core.Application.Services.Interface
{
    public interface IEntryService
    {
        IList<Entry> All();
        Entry FindById(int id);
        bool Add(Entry entry);
        bool UpdateEntry(Entry oldEntry, Entry newEntry);
    }
}
