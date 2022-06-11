using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entity;

namespace Core.DataAccess
{
    // repository generic design pattern
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}