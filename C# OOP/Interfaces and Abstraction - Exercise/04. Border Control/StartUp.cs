using System;
using System.Collections.Generic;
using System.Linq;
using _04._Border_Control.Models.Contracts;

namespace _04._Border_Control
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdCheckable> borderInformation = new List<IIdCheckable>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] tokens = command.Split(' ',StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 3)
                {
                    string name = tokens[0];
                    
                    int age = int.Parse(tokens[1]);

                    string id = tokens[2];

                    Citizen citizen = new Citizen(name, age, id);

                    borderInformation.Add(citizen);
                }
                else
                {
                    string name = tokens[0];

                    string id = tokens[1];

                    Robot robot = new Robot(name, id);

                    borderInformation.Add(robot);
                }
            }

            string idCheck = Console.ReadLine();

            borderInformation = borderInformation.Where(x => x.Id.EndsWith(idCheck)).ToList();

            borderInformation.ForEach(x => Console.WriteLine(x.Id));
        }
    }
}
