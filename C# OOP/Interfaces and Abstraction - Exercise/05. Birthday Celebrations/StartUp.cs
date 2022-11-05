using System;
using System.Collections.Generic;
using System.Linq;
using Birthday_Celebrations.Models.Contracts;

namespace _05._Birthday_Celebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthdatable> birthDateInformation = new List<IBirthdatable>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Citizen")
                {
                    string name = tokens[1];

                    int age = int.Parse(tokens[2]);

                    string id = tokens[3];

                    string birthday = tokens[4];

                    Citizen citizen = new Citizen(name, age, id, birthday);

                    birthDateInformation.Add(citizen);
                }
                else if (tokens[0] == "Pet")
                {
                    string name = tokens[1];

                    string birthday = tokens[2];

                    Pet pet = new Pet(name, birthday);

                    birthDateInformation.Add(pet);
                }
            }

            string yearCheck = Console.ReadLine();

            birthDateInformation = birthDateInformation.Where(x => x.BirthDate.EndsWith(yearCheck)).ToList();

            birthDateInformation.ForEach(x => Console.WriteLine(x.BirthDate));
        }
    }
}