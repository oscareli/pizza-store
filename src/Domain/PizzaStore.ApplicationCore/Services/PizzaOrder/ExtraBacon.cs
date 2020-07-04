using System;

namespace PizzaStore.ApplicationCore.Services
{
    public class ExtraBacon : IPizzaDecorator
    {
        public string Sabor { get; set; }

        public IPizza pizza { get; set; }

        public ExtraBacon(IPizza pizza)
        {
            this.Sabor = pizza.Sabor + ",extra baecon";
            this.pizza = pizza;
        }

        public Custo Custo()
        {
            return new Custo()
            {
                TempoDePreparo = pizza.Custo().TempoDePreparo,
                Valor = 3.00 + pizza.Custo().Valor
            };
        }
    }
}
