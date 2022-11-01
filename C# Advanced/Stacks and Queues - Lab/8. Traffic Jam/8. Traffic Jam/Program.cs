using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfGreenPasses = int.Parse(Console.ReadLine());
            int countOfPassedCars = 0;
            Queue<string> carsQueue = new Queue<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    Console.WriteLine($"{countOfPassedCars} cars passed the crossroads.");
                    break;
                }
                if (command == "green")
                {
                    int count = 0;
                    if (carsQueue.Count < countOfGreenPasses)
                    {
                        count = carsQueue.Count;
                        for (int i = 0; i < count; i++)
                        {
                            countOfPassedCars++;
                            Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < countOfGreenPasses; i++)
                        {
                            countOfPassedCars++;
                            Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        }
                    }
                    continue;
                }
                if (command != "end" && command != "green")
                {
                    carsQueue.Enqueue(command);
                }
            }
        }
    }
}
