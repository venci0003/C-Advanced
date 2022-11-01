using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < loops; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                try
                {
                    Person person = new Person(cmdArgs[0],
                                     cmdArgs[1],
                                      int.Parse(cmdArgs[2]),
                                      decimal.Parse(cmdArgs[3]));
                    persons.Add(person);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            Team team = new Team("SoftUni");
            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }
            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
        }
    }
}
