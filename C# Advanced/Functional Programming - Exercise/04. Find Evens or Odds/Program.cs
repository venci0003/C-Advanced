using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> even = number => number % 2 == 0;
            Predicate<int> odd = number => number % 2 != 0;

            int[] range = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

            bool isEven = Console.ReadLine() == "even";

            List<int> numbers = new List<int>();

            List<int> result = new List<int>();

            for (int i = range[0]; i <= range[1]; i++)
            {
                numbers.Add(i);
            }

            if (isEven)
            {
                result = numbers.FindAll(even);
            }
            else
            {
                result = numbers.FindAll(odd);
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
