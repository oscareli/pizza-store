
using System.Collections.Generic;
using PizzaStore.ApplicationCore.Entities;

namespace PizzaStore.ApplicationCore.Services
{
    public class Tamanho
    {
        public int Tempo { get; set; }
        public double Valor { get; set; }
        public string Nome { get; set; }
    }

    public class PizzaCatalog
    {
        public IList<Tamanho> Tamanhos { get; }
        public IList<string> Sabores { get; }

        public IList<string> Personalizacao { get; set; }

        public PizzaCatalog()
        {
            Tamanhos = new List<Tamanho>()
            {
                new Tamanho()
                {
                    Tempo = 15,
                    Valor = 20.00,
                    Nome = "pequena"
                },

                new Tamanho()
                {
                    Tempo = 20,
                    Valor = 30.00,
                    Nome = "media"
                },

                new Tamanho()
                {
                    Tempo = 25,
                    Valor = 45.00,
                    Nome = "grande"
                }
            };

            Sabores = new List<string>()
            {
                "calabresa", "marguerita", "portuguesa"
            };

            Personalizacao = new List<string>()
            {
                "extra bacon", "sem cebola", "borda recheada"
            };
        }

    }
}
