using System;

namespace _03._Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int forLoops = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < forLoops; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                family.AddMember(person);
            }

            Person oldestFamilyMember = family.GetOldestMember();

            Console.WriteLine($"{oldestFamilyMember.Name} {oldestFamilyMember.Age}");
        }
    }
}
