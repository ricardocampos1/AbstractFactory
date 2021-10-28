using FurnitureStore.AbstractFactory;
using FurnitureStore.Interfaces;

namespace FurnitureStore.ConcreteProduct
{
    public class FurnitureClient
    {
        readonly IChair chair;
        readonly ICoffeeTable coffeeTable;
        readonly ISofa sofa;

        public FurnitureClient(IFurnitureFactory factory, string type)
        {
            chair = factory.GetChair(type);
            coffeeTable = factory.GetCoffeeTable(type);
            sofa = factory.GetSofa(type);
        }

        public string GetChairName() => chair.Name();

        public string GetCoffeeTable() => coffeeTable.Name();

        public string GetSofa() => sofa.Name();
    }
}
