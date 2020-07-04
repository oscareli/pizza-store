using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using PizzaStore.ApplicationCore.Entities;
using PizzaStore.ApplicationCore.Services;

namespace PizzaStore.ApplicationCore.Interfaces.Services
{
    public interface IPizzaOrderService
    {
        PizzaOrder Create(PizzaOrder entity);

        IEnumerable<PizzaOrder> Read();

        PizzaOrder Read(int id);

        IEnumerable<PizzaOrder> Read(Expression<Func<PizzaOrder, bool>> query);

        void Update(PizzaOrder entity);

        void Delete(PizzaOrder entity);
        
        PizzaCatalog GetPizzaCatalog();
    }
}
