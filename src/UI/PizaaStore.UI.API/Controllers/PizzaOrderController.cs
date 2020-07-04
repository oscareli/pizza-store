using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.ApplicationCore.Entities;
using PizzaStore.ApplicationCore.Interfaces.Services;
namespace PizaaStore.UI.API.Controllers
{
    [ApiController]
    [Route("/api/pizza-order")]
    public class PizzaOrderController : ControllerBase
    {
        private readonly IPizzaOrderService _pizzaOrderService;

        public PizzaOrderController(IPizzaOrderService pizzaOrderService)
        {
            _pizzaOrderService = pizzaOrderService;
        }

        [HttpPost]
        public PizzaOrder Post(PizzaOrder pizzaOrder)
        {
            return _pizzaOrderService.Create(pizzaOrder);
        }

        [HttpGet("{pizzaOrderId}")]
        public PizzaOrder Get(int pizzaOrderId)
        {
            return _pizzaOrderService.Read(pizzaOrderId);
        }
    }
}
