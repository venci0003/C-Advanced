using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    Console.WriteLine($"{customers.Count} people remaining.");
                    break;
                }
                if (command == "Paid")
                {
                    int counter  = customers.Count;
                    for (int i = 0; i < counter; i++)
                    {
                        Console.WriteLine($"{customers.Dequeue()}");
                    }
                }
                if (command != "End" && command != "Paid")
                {
                    customers.Enqueue(command);
                }
            }
        }
    }
}
