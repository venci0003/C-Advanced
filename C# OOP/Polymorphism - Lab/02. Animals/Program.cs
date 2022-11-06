using System;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Peter", "Whiskas");
            Animal dog = new Dog("George", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());

        }
    }
}
