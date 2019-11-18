
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

    public class Personalizacao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    public class PizzaCatalog
    {
        public IList<Tamanho> Tamanhos { get; }
        public IList<string> Sabores { get; }

        public IList<Personalizacao> Personalizacao { get; set; }

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
                    Nome = "média"
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

            Personalizacao = new List<Personalizacao>()
            {
                new Personalizacao()
                {
                    Id = 0,
                    Nome = "extra bacon"
                },

                new Personalizacao()
                {
                    Id = 1,
                    Nome = "sem cebola"
                },

                new Personalizacao()
                {
                    Id = 2,
                    Nome = "borda recheada"
                }
            };
        }

    }
}
