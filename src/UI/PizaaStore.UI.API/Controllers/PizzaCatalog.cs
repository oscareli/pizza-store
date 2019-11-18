using System;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.ApplicationCore.Interfaces.Services;
using PizzaStore.ApplicationCore.Services;

namespace PizaaStore.UI.API.Controllers
{
    [ApiController]
    [Route("/api/pizza-catalog")]
    public class PizzaCatalogController : ControllerBase
    {
        private readonly IPizzaOrderService _pizzaOrderService;

        public PizzaCatalogController(IPizzaOrderService pizzaOrderService)
        {
            _pizzaOrderService = pizzaOrderService;
        }

        [HttpGet]
        public PizzaCatalog Get()
        {
            return _pizzaOrderService.GetPizzaCatalog();
        }
    }
}
