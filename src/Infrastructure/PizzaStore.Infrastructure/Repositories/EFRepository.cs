using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PizzaStore.ApplicationCore.Interfaces.Repositories;
using PizzaStore.Infrastructure.Data;

namespace PizzaStore.Infrastructure.Repository
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        protected readonly PizzaOrderContext dbContext;

        public EFRepository(PizzaOrderContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public T Create(T entity)
        {
            this.dbContext.Set<T>().Add(entity);
            this.dbContext.SaveChanges();

            return entity;
        }

        public void Delete(T entity)
        {
            this.dbContext.Set<T>().Remove(entity);
            this.dbContext.SaveChanges();
        }

        public IEnumerable<T> Read()
        {
            return this.dbContext.Set<T>().AsEnumerable();
        }

        public T Read(int id)
        {
            return this.dbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> Read(Expression<Func<T, bool>> query)
        {
            return this.dbContext.Set<T>().Where(query).AsEnumerable();
        }

        public void Update(T entity)
        {
            this.dbContext.Entry(entity).State = EntityState.Modified;
            this.dbContext.SaveChanges();
        }
    }
}
