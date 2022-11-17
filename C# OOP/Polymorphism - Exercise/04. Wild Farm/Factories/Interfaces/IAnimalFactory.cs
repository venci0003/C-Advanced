namespace WildFarm.Factories.Interfaces
{
    using Models.Interfaces;

    public interface IAnimalFactory
    {
        IAnimal CreateAnimal(string[] cmdArgs);
    }
}
