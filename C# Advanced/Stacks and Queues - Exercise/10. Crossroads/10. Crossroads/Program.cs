using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightInput = int.Parse(Console.ReadLine());
            int freeWindowInput = int.Parse(Console.ReadLine());
            var traffic = new Queue<string>();
            int passed = 0;
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "END") break;
                if (cmd == "green")
                {
                    int greenLight = greenLightInput;
                    int freeWindow = freeWindowInput;

                    while (greenLight > 0 && traffic.Count > 0)
                    {
                        string currentCar = traffic.Peek();
                        if (greenLight >= currentCar.Length)
                        {
                            greenLight -= currentCar.Length;
                            traffic.Dequeue();
                            passed++;
                        }
                        else
                        {
                            if (currentCar.Length <= greenLight + freeWindow)
                            {
                                greenLight -= currentCar.Length;
                                traffic.Dequeue();
                                passed++;
                            }
                            else
                            {
                                currentCar = traffic.Peek();
                                Console.WriteLine($"A crash happened!\n{currentCar} was hit at {currentCar[greenLight + freeWindow]}.");
                                return;
                            }
                        }
                    }
                }
                else
                {
                    traffic.Enqueue(cmd);
                }
            }
            Console.WriteLine($"Everyone is safe.\n{passed} total cars passed the crossroads.");
        }
    }
}
