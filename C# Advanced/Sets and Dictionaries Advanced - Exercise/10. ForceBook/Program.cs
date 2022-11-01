using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedSet<string>> sidesUsers = new SortedDictionary<string, SortedSet<string>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Lumpawaroo")
                {
                    break;
                }

                if (command.Contains('|'))
                {
                    string[] tokens = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    string side = tokens[0];
                    string user = tokens[1];

                    if (!sidesUsers.Values.Any(u => u.Contains(user)))
                    {
                        if (!sidesUsers.ContainsKey(side))
                        {
                            sidesUsers.Add(side, new SortedSet<string>());
                        }

                        sidesUsers[side].Add(user);
                    }
                }
                else
                {
                    string[] tokens = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string side = tokens[1];
                    string user = tokens[0];

                    foreach (var sideUsers in sidesUsers)
                    {
                        if (sideUsers.Value.Contains(user))
                        {
                            sideUsers.Value.Remove(user);
                            break;
                        }
                    }

                    if (!sidesUsers.ContainsKey(side))
                    {
                        sidesUsers.Add(side, new SortedSet<string>());
                    }

                    sidesUsers[side].Add(user);

                    Console.WriteLine($"{user} joins the {side} side!");
                }
            }

            var orderedSidesUsers = sidesUsers.OrderByDescending(s => s.Value.Count);

            foreach (var sideUsers in orderedSidesUsers)
            {
                if (sideUsers.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {sideUsers.Key}, Members: {sideUsers.Value.Count}");

                    foreach (var user in sideUsers.Value)
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
