using System;

namespace PizzaStore.ApplicationCore.Services
{
    public class Portuguesa : IPizza
    {
        public string Sabor { get; set; }

        public Portuguesa()
        {
            this.Sabor = "portuguesa";
        }

        public Custo Custo()
        {
            return new Custo()
            {
                TempoDePreparo = 5,
                Valor = 0
            };
        }
    }
}
