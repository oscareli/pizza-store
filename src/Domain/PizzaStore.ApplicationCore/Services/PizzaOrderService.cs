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
            IPizza pizza = null;

            if (entity.Sabor == "calabresa")
            {
                pizza = new Calabresa();
            }

            if (entity.Sabor == "marguerita")
            {
                pizza = new Marguerita();
            }

            if (entity.Sabor == "portuguesa")
            {
                pizza = new Portuguesa();
            }

            if (entity.Tamando == "pequena")
            {
                pizza = new Pequena(pizza);
            }

            if (entity.Tamando == "média")
            {
                pizza = new Media(pizza);
            }

            if (entity.Tamando == "grande")
            {
                pizza = new Grande(pizza);
            }

            var personalizacoes = entity.Personalizacao.Split(",");

            foreach (var item in personalizacoes)
            {
                if (item == "borda recheada")
                {
                    pizza = new BordaRecheada(pizza);
                }

                if (item == "extra bacon")
                {
                    pizza = new ExtraBacon(pizza);
                }

                if (item == "sem cebola")
                {
                    pizza = new SemCebola(pizza);
                }
            }

            entity.ValorTotal = pizza.Custo().Valor;
            entity.TempoDePreparo = pizza.Custo().TempoDePreparo;


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
