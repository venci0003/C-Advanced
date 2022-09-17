using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] playersNames = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());
            
            Queue<string> players = new Queue<string>(playersNames);
            int tosses = 1;
            while (players.Count > 1)
            {
                string currentPlayer = players.Dequeue();
                if (tosses == n)
                {
                    Console.WriteLine($"Removed {currentPlayer}");
                    tosses = 1;
                    continue;
                }
                tosses++;
                players.Enqueue(currentPlayer);
            }
            Console.WriteLine($"Last is {players.Dequeue()}");
        }
    }
}
