using System;
using System.Linq;
using System.Collections.Generic;
namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int forLoops = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < forLoops; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "1")
                {
                    int numberToBeAdded = int.Parse(command[1]);
                    stack.Push(numberToBeAdded);
                }
                else if (command[0] == "2")
                {
                    stack.Pop();
                }
                else if (command[0] == "3" && stack.Any())
                {
                    Console.WriteLine(stack.Max());
                }
                else if (command[0] == "4" && stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
            }
            Console.WriteLine(String.Join(", ",stack));
        }
    }
}
