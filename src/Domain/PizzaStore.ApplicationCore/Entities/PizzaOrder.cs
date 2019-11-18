using System;

namespace PizzaStore.ApplicationCore.Entities
{
    public class PizzaOrder
    {
        public int PizzaOrderId { get; set; }

        public int ClientId { get; set; }

        public string Sabor { get; set; }

        public string Tamando { get; set; }

        public PersonalizacaoEnum Personalizacao { get; set; }

        public decimal ValorTotal { get; set; }

        public DateTime TempoDePreparo { get; set; }

        public PizzaOrder()
        {
            
        }
    }
}
