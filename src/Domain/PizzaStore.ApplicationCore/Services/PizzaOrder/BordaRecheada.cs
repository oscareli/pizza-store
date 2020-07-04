using System;

namespace PizzaStore.ApplicationCore.Services
{
    public class BordaRecheada : IPizzaDecorator
    {
        public string Sabor { get; set; }

        public IPizza pizza { get; set; }

        public BordaRecheada(IPizza pizza)
        {
            this.Sabor = pizza.Sabor + ",borda recheada";
            this.pizza = pizza;
        }

        public Custo Custo()
        {
            return new Custo()
            {
                TempoDePreparo = 5 + pizza.Custo().TempoDePreparo,
                Valor = 5.00 + pizza.Custo().Valor
            };
        }
    }
}
