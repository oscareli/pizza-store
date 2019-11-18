using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PizzaStore.ApplicationCore.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Create(T entity);

        IEnumerable<T> Read();

        T Read(int id);

        IEnumerable<T> Read(Expression<Func<T, bool>> query);

        void Update(T entity);

        void Delete(T entity);
    }
}
