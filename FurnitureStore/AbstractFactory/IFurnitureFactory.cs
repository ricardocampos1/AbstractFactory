using FurnitureStore.Interfaces;

namespace FurnitureStore.AbstractFactory
{
    public interface IFurnitureFactory
    {
        IChair GetChair(string chair);
        ISofa GetSofa(string sofa);
        ICoffeeTable GetCoffeeTable(string coffeeTable);
    }
}
