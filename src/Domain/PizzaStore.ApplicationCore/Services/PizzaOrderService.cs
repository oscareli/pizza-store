using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using PizzaStore.ApplicationCore.Entities;
using PizzaStore.ApplicationCore.Interfaces.Services;
using PizzaStore.Infrastructure.Repositories;

namespace PizzaStore.ApplicationCore.Services
{
    public class PizzaOrderService : IPizzaOrderService
    {

        private readonly IPizzaOrderRepository pizzaOrderRepository;


        public PizzaOrderService(IPizzaOrderRepository pizzaOrderRepository)
        {
            this.pizzaOrderRepository = pizzaOrderRepository;
        }

        public PizzaCatalog GetPizzaCatalog()
        {
            return new PizzaCatalog();
        }


        public PizzaOrder Create(PizzaOrder entity)
        {
            // TODO: Make a pizza!

            return pizzaOrderRepository.Create(entity);
        }

        public void Delete(PizzaOrder entity)
        {
            pizzaOrderRepository.Delete(entity);
        }

        public IEnumerable<PizzaOrder> Read()
        {
            return pizzaOrderRepository.Read();
        }

        public PizzaOrder Read(int id)
        {
            return pizzaOrderRepository.Read(id);
        }

        public IEnumerable<PizzaOrder> Read(Expression<Func<PizzaOrder, bool>> query)
        {
            return pizzaOrderRepository.Read(query);
        }

        public void Update(PizzaOrder entity)
        {
            pizzaOrderRepository.Update(entity);
        }
    }
}
