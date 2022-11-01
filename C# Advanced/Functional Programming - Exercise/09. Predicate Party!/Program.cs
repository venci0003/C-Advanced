using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Party!")
                {
                    break;
                }

                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = tokens[0];
                string filter = tokens[1];
                string value = tokens[2];

                if (action == "Remove")
                {
                    people.RemoveAll(GetPredicate(filter, value));
                }
                else
                {
                    var peopleDouble = people.FindAll(GetPredicate(filter, value));

                    int index = people.FindIndex(GetPredicate(filter, value));
                    if (index >= 0)
                    {
                        people.InsertRange(index, peopleDouble);
                    }
                }
            }

            if (people.Any())
            {
                Console.WriteLine($"{string.Join(", ",people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static Predicate<string> GetPredicate(string filter, string value)
        {
            if (filter == "StartsWith")
            {
                return s => s.StartsWith(value);
            }
            else if (filter == "EndsWith")
            {
                return s => s.EndsWith(value);
            }
            else if (filter == "Length")
            {
                return s => s.Length == int.Parse(value);
            }
            else
            {
                return null;
            }
        }
    }
}
