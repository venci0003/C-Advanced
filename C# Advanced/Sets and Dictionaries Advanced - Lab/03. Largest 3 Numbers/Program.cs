using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(n => int.Parse(n)).ToList();

            numbers = numbers.OrderByDescending(n => n).ToList();

            if (numbers.Count < 3)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    int currentNumber = numbers[i];
                    Console.Write($"{currentNumber} ");
                }
                return;
            }
            for (int i = 0; i < 3; i++)
            {
                int currentNumber = numbers[i];
                Console.Write($"{currentNumber} ");
            }
        }
    }
}
