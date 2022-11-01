using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> firstSetOfNumbers = new HashSet<int>();
            HashSet<int> secondSetOfNumbers = new HashSet<int>();

            int[] inputCounters = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();
            int firstCounter = inputCounters[0];
            int secondCounter = inputCounters[1];

            for (int i = 0; i < firstCounter; i++)
            {
                int numbersInput = int.Parse(Console.ReadLine());
                firstSetOfNumbers.Add(numbersInput);
            }

            for (int i = 0; i < secondCounter; i++)
            {
                int numbersInput = int.Parse(Console.ReadLine());
                secondSetOfNumbers.Add(numbersInput);
            }

            firstSetOfNumbers.IntersectWith(secondSetOfNumbers);
            Console.WriteLine(String.Join(" ",firstSetOfNumbers));
        }
    }
}
