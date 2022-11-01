using System;
using System.Linq;
using System.Collections.Generic;
namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPetrolPumps = int.Parse(Console.ReadLine());

            Queue<int[]> petrolPumpInformation = new Queue<int[]>();
            for (int i = 0; i < countOfPetrolPumps; i++)
            {
                int[] info = Console.ReadLine().Split().Select(int.Parse).ToArray();

                petrolPumpInformation.Enqueue(info);
            }

            int indexToStartTour = 0;
            while (true)
            {
                int capacityTank = 0;
                bool isFinished = true;
                foreach (var petrolPump in petrolPumpInformation)
                {
                    capacityTank += petrolPump[0];
                    if (capacityTank - petrolPump[1] >= 0)
                    {
                        capacityTank -= petrolPump[1];
                    }
                    else
                    {
                        isFinished = false;
                        break;
                    }
                }
                if (isFinished)
                {
                    Console.WriteLine(indexToStartTour);
                    break;
                }
                else
                {
                    int[] removed = petrolPumpInformation.Dequeue();
                    petrolPumpInformation.Enqueue(removed);
                    indexToStartTour++;
                }
            }
        }
    }
}
