using System;

namespace PizzaStore.ApplicationCore.Services
{
    public class SemCebola : IPizzaDecorator
    {
        public string Sabor { get; set; }

        public IPizza pizza { get; set; }

        public SemCebola(IPizza pizza)
        {
            this.Sabor = pizza.Sabor + ",sem cebela";
            this.pizza = pizza;
        }

        public Custo Custo()
        {
            return new Custo()
            {
                TempoDePreparo = pizza.Custo().TempoDePreparo,
                Valor = pizza.Custo().Valor
            };
        }
    }
}
