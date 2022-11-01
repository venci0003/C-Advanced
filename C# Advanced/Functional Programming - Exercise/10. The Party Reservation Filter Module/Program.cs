using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .ToList();

            Dictionary<string, Predicate<string>> filters = new Dictionary<string, Predicate<string>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Print")
                {
                    break;
                }

                string[] tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries);

                string action = tokens[0];
                string filter = tokens[1];
                string value = tokens[2];

                if (action == "Add filter")
                {
                    filters.Add(filter + value, GetPredicate(filter, value));
                }
                else
                {
                    filters.Remove(filter + value);
                }
            }

            foreach (var filter in filters)
            {
                people.RemoveAll(filter.Value);
            }

            Console.WriteLine(string.Join(" ", people));
        }

        static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "Starts with":
                    return s => s.StartsWith(value);
                case "Ends with":
                    return s => s.EndsWith(value);
                case "Length":
                    return s => s.Length == int.Parse(value);
                case "Contains":
                    return s => s.Contains(value);
                default:
                    return default(Predicate<string>);
            }
        }
    }
}