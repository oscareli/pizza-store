using System;

namespace PizzaStore.ApplicationCore.Services
{
    public class Media : IPizzaDecorator
    {
        public string Sabor { get; set; }

        public IPizza pizza { get; set; }

        public Media(IPizza pizza)
        {
            this.Sabor = pizza.Sabor + ",media";
            this.pizza = pizza;
        }

        public Custo Custo()
        {
            return new Custo()
            {
                TempoDePreparo = 20 + pizza.Custo().TempoDePreparo,
                Valor = 30.00 + pizza.Custo().Valor
            };
        }
    }
}
