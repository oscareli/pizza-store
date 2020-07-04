using System;
using PizzaStore.ApplicationCore.Entities;
using PizzaStore.Infrastructure.Data;
using PizzaStore.Infrastructure.Repository;

namespace PizzaStore.Infrastructure.Repositories
{
    public class PizzaOrderRepository : EFRepository<PizzaOrder>, IPizzaOrderRepository
    {
        public PizzaOrderRepository(PizzaOrderContext dbContext) : base(dbContext)
        {
            
        }

    }
}
