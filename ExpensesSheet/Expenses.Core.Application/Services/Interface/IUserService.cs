using Expenses.Core.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Core.Application.Services.Interface
{
    public interface IUserService
    {
        IList<User> All();
    }
}
