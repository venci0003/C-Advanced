using System;

namespace Explicit_Interfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string[] inputInformation = Console.ReadLine().Split();

                if (inputInformation[0] == "End")
                {
                    break;
                }
                string name = inputInformation[0];

                Citizen citizen = new Citizen(name);

                IResident resident = citizen;

                IPerson person = citizen;

                Console.WriteLine(citizen.Name);

                Console.WriteLine($"{resident.GetName()} {person.GetName()}");
            }
        }
    }
}
