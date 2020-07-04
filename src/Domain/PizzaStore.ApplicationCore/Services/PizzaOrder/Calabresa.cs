using System;

namespace PizzaStore.ApplicationCore.Services
{
    public class Calabresa : IPizza
    {
        public string Sabor { get; set; }

        public Calabresa()
        {
            this.Sabor = "calabresa";
        }

        public Custo Custo()
        {
            return new Custo()
            {
                TempoDePreparo = 0,
                Valor = 0
            };
        }
    }
}
