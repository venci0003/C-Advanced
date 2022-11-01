using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int countOfElementsToBeQueued = commands[0];
            int countOfElementsToBeDequeued = commands[1];
            int elementToLookFor = commands[2];

            int[] numbersInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < countOfElementsToBeQueued; i++)
            {
                numbers.Enqueue(numbersInput[i]);
            }

            for (int i = 0; i < countOfElementsToBeDequeued; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Count <= 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (numbers.Contains(elementToLookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine($"{numbers.Min()}");
            }
        }
    }
}
