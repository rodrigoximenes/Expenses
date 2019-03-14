using System.Collections.Generic;

namespace Expenses.Core.Domain.Interface
{
    public interface IBaseRepository<TEntity>
    {
        void Add(TEntity entity);

        void Delete(int id);

        void Update(TEntity entity);

        TEntity Find(int id);

        IList<TEntity> FindAll();
    }
}
