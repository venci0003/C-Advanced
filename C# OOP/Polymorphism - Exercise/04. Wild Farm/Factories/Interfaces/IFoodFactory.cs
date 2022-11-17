namespace WildFarm.Factories.Interfaces
{
    using Models.Interfaces;

    public interface IFoodFactory
    {
        IFood CreateFood(string type, int quantity);
    }
}
