using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbersInStack = new Stack<int>();
            foreach (var number in numbers)
            {
                numbersInStack.Push(number);
            }

            while (true)
            {
                string command = Console.ReadLine().ToLower();
                string[] tokens = command.Split();
                if (tokens[0] == "end")
                {
                    Console.WriteLine($"Sum: {numbersInStack.Sum()}");
                    break;
                }
               else if (tokens[0] == "add")
                {
                    int firstNumber = int.Parse(tokens[1]);
                    int secondNumber = int.Parse(tokens[2]);
                    numbersInStack.Push(firstNumber);
                    numbersInStack.Push(secondNumber);
                }
                else if (tokens[0] == "remove")
                {
                    
                    int numberCountToRemove = int.Parse(tokens[1]);
                    if (numbersInStack.Count >= numberCountToRemove)
                    {
                        for (int i = 0; i < numberCountToRemove; i++)
                        {
                            numbersInStack.Pop();
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
