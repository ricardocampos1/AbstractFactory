using FurnitureStore.ConcreteProduct;
using FurnitureStore.Interfaces;
using System;

namespace FurnitureStore.AbstractFactory
{
    public class ArtDecoFactory : IFurnitureFactory
    {
        public IChair GetChair(string chair)
        {
            return chair switch
            {
                "Cheap" => new CheapChair(),
                "Expensive" => new ExpensiveChair(),
                _ => throw new ApplicationException(string.Format("Furniture '{0}' cannot be created", chair)),
            };
        }

        public ICoffeeTable GetCoffeeTable(string coffeeTable)
        {
            return coffeeTable switch
            {
                "Cheap" => new CheapCoffeeTable(),
                "Expensive" => new ExpensiveCoffeeTable(),
                _ => throw new ApplicationException(string.Format("Furniture '{0}' cannot be created", coffeeTable)),
            };
        }

        public ISofa GetSofa(string sofa)
        {
            return sofa switch
            {
                "Cheap" => new CheapSofa(),
                "Expensive" => new ExpensiveSofa(),
                _ => throw new ApplicationException(string.Format("Furniture '{0}' cannot be created", sofa)),
            };
        }
    }
}
