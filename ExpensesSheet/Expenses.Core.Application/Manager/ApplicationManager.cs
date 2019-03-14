using System;
using Expenses.Core.Application.Services.Interface;
using Expenses.Infrastructure.DependencyInjection;

namespace Expenses.Core.Application.Manager
{
    /// <summary>
    /// Gerenciador entre as camadas Presentation/Application
    /// </summary>
    public class ApplicationManager : IApplicationManager
    {
        public IEntryService EntryService => CompositionRoot.Resolve<IEntryService>();
    }
}
