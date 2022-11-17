using System;
using WildFarm.Factories.Interfaces;
using WildFarm.Factories;
using WildFarm.IO.Interfaces;
using WildFarm.IO;
using WildFarm.Core.Interfaces;
using WildFarm.Core;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IAnimalFactory animalFactory = new AnimalFactory();
            IFoodFactory foodFactory = new FoodFactory();

            IEngine engine = new Engine(reader, writer, animalFactory, foodFactory);
            engine.Run();
        }
    }
}
