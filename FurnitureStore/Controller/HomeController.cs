using FurnitureStore.AbstractFactory;
using FurnitureStore.ConcreteProduct;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FurnitureStore.Controller
{
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet, Route("store")]
        public IActionResult Index()
        {
            IFurnitureFactory mordern = new ModernFactory();

            FurnitureClient mordernClient = new(mordern, "Expensive");
            Console.WriteLine("******* Mordern *******");
            Console.WriteLine(mordernClient.GetChairName());
            Console.WriteLine(mordernClient.GetCoffeeTable());

            mordernClient = new(mordern, "Cheap");
            Console.WriteLine(mordernClient.GetChairName());
            Console.WriteLine(mordernClient.GetCoffeeTable());

            mordernClient = new(mordern, "Expensive");
            Console.WriteLine(mordernClient.GetSofa());

            IFurnitureFactory victorian = new VictorianFactory();
            FurnitureClient victorianClient = new(victorian, "Expensive");

            Console.WriteLine("******* Victorian *******");
            Console.WriteLine(victorianClient.GetChairName());
            Console.WriteLine(victorianClient.GetCoffeeTable());

            victorianClient = new(victorian, "Cheap");
            Console.WriteLine(victorianClient.GetChairName());
            Console.WriteLine(victorianClient.GetCoffeeTable());

            victorianClient = new(victorian, "Expensive");
            Console.WriteLine(victorianClient.GetSofa());

            return Ok();
        }
    }
}
