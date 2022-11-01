using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<List<int>> add = numbers =>
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i]++;
                }
            };
            Action<List<int>> multiply = numbers =>
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i] *= 2;
                }
            };
            Action<List<int>> subtract = numbers =>
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i]--;
                }
            };

            Action<List<int>> print = numbers => Console.WriteLine(string.Join(" ", numbers));

            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                if (command == "add")
                {
                    add(numbers);
                }
                else if (command == "multiply")
                {
                    multiply(numbers);
                }
                else if (command == "subtract")
                {
                    subtract(numbers);
                }
                else if (command == "print")
                {
                    print(numbers);
                }
            }
        }
    }
}
