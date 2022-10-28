using System;

namespace _02._Creating_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();

            Person secondPerson = new Person()
            {
                Age = 32
            };

            Person thirdPerson = new Person()
            {
                Name = "Jose",
                Age = 43
            };

            Console.WriteLine($"{firstPerson.Name} {firstPerson.Age}");

            Console.WriteLine($"{secondPerson.Name} {secondPerson.Age}");

            Console.WriteLine($"{thirdPerson.Name} {thirdPerson.Age}");
        }
    }
}
