using Expenses.Core.Application.Services.Interface;
using Expenses.Core.Domain.Interface;
using Expenses.Core.Domain.Model;
using Expenses.Infrastructure.DependencyInjection;
using System.Collections.Generic;

namespace Expenses.Core.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository = CompositionRoot.Resolve<IUserRepository>();

        public IList<User> All()
        {
            return _userRepository.FindAll();
        }
    }
}
