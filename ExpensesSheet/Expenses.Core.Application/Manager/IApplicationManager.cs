using Expenses.Core.Application.Services.Interface;

namespace Expenses.Core.Application.Manager
{
    public interface IApplicationManager
    {
        IEntryService EntryService { get; }
    }
}