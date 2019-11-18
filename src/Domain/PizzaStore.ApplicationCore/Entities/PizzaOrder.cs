using System;
using System.Collections.Generic;

namespace PizzaStore.ApplicationCore.Entities
{
    public class PizzaOrder
    {
        public int PizzaOrderId { get; set; }

        public int ClientId { get; set; }

        public string Sabor { get; set; }

        public string Tamando { get; set; }

        public string Personalizacao { get; set; }

        public double ValorTotal { get; set; }

        public int TempoDePreparo { get; set; }

        public PizzaOrder()
        {
            
        }
    }
}
