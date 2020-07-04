using System;

namespace PizzaStore.ApplicationCore.Services
{
    public interface IPizza
    {
        string Sabor { get; set; }

        Custo Custo();
    }
}
