using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Food_Shortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());

            List<IBuyable> information = new List<IBuyable>();

            for (int i = 0; i < countOfPeople; i++)
            {
                string command = Console.ReadLine();

                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 4)
                {
                    string name = tokens[0];

                    int age = int.Parse(tokens[1]);

                    string id = tokens[2];

                    string birthday = tokens[3];

                    IBuyable citizen = new Citizen(name, age, id, birthday);

                    information.Add(citizen);
                }
                else if (tokens.Length == 3)
                {
                    string name = tokens[0];

                    int age = int.Parse(tokens[1]);

                    string group = tokens[2];

                    IBuyable rebel = new Rebel(name, age, group);

                    information.Add(rebel);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                if (information.Any(x => x.Name == command))
                {
                    IBuyable currentBuyer = information.First(x => x.Name == command);

                    currentBuyer.BuyFood();
                }
            }
            int sum = information.Sum(x => x.Food);

            Console.WriteLine(sum);
        }
    }
}
