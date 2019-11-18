using System;

namespace PizzaStore.ApplicationCore.Services
{
    public class Pequena : IPizzaDecorator
    {
        public string Sabor { get; set; }
        public IPizza pizza { get; set; }

        public Pequena(IPizza pizza)
        {
            this.Sabor = pizza.Sabor + ",pequena";
            this.pizza = pizza;
        }

        public Custo Custo()
        {
            return new Custo()
            {
                TempoDePreparo = 15 + pizza.Custo().TempoDePreparo,
                Valor = 20.00 + pizza.Custo().Valor
            };
        }
    }
}
