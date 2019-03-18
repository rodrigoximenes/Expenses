using System;
using System.Collections.Generic;
using Expenses.Core.Application.Services.Interface;
using Expenses.Core.Domain.Model;
using Expenses.Core.Domain.Interface;
using Expenses.Infrastructure.DependencyInjection;

namespace Expenses.Core.Application.Services
{
    /// <summary>
    /// Acessa o Repositório e distribui as regras de negócio e casos de uso
    /// </summary>
    public class EntryService : IEntryService
    {
        private readonly IEntryRepository _entryRepository = CompositionRoot.Resolve<IEntryRepository>();

        public Entry FindById(int id)
        {
            return _entryRepository.Find(id);
        }

        public IList<Entry> All()
        {
            return _entryRepository.FindAll();
        }

        public bool Add(Entry entry)
        {
            try
            {
                _entryRepository.Add(entry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateEntry(Entry oldEntry, Entry newEntry)
        {
            try
            {
                oldEntry.Description = newEntry.Description;
                oldEntry.IsExpense = newEntry.IsExpense;
                oldEntry.Value = newEntry.Value;

                _entryRepository.Update(oldEntry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
