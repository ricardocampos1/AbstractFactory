using FurnitureStore.Interfaces;

namespace FurnitureStore.ConcreteProduct
{
    public class ExpensiveCoffeeTable : ICoffeeTable
    {
        public string Name()
        {
            return "Expensive Coffee Table- Name";
        }
    }
}
