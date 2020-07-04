using System;

namespace PizzaStore.ApplicationCore.Services
{
    public class Grande : IPizza
    {
        public string Sabor { get; set; }

        public IPizza pizza { get; set; }

       public Grande(IPizza pizza)
        {
            this.Sabor = pizza.Sabor + ",grande";
            this.pizza = pizza;
        }


        public Custo Custo()
        {
            return new Custo()
            {
                TempoDePreparo = 25 + pizza.Custo().TempoDePreparo,
                Valor = 40.00 + pizza.Custo().Valor
            };
        }
    }
}
