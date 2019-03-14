using Expenses.Core.Domain.Interface;
using Expenses.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Expenses.Infrastructure.Repository
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly ExpensesContext _context;

        public BaseRepository(ExpensesContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = Find(id);

            _context.Entry(entity).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public TEntity Find(int id)
        {
            try
            {
                return _context.Set<TEntity>().Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<TEntity> FindAll()
        {
            try
            {
                return _context.Set<TEntity>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
