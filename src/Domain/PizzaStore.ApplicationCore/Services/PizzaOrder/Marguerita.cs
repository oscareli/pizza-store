using System;

namespace PizzaStore.ApplicationCore.Services
{
    public class Marguerita : IPizza
    {
        public string Sabor { get; set; }

        public Marguerita()
        {
            this.Sabor = "marguerita";
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
