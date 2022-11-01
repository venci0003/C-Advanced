using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Opinion_Poll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int forLoops = int.Parse(Console.ReadLine());

            List<Person> peopleOver30YearsOld = new List<Person>();

            for (int i = 0; i < forLoops; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                if (age > 30)
                {
                    peopleOver30YearsOld.Add(person);
                }
            }

            foreach (var people in peopleOver30YearsOld.OrderBy(p => p.Name))
            {
                Console.WriteLine($"{people.Name} - {people.Age}");
            }
        }
    }
}
