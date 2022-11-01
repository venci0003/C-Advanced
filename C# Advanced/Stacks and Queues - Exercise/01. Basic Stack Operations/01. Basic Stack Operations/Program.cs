using System;
using System.Linq;
using System.Collections.Generic;
namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbersInputStack = new Stack<int>();

            int pushCount = commands[0];
            int popCount = commands[1];
            int elementToBeFound = commands[2];

            for (int i = 0; i < pushCount; i++)
            {
                numbersInputStack.Push(numbersInput[i]);
            }
            for (int i = 0; i < popCount; i++)
            {
                numbersInputStack.Pop();
            }
            if (numbersInputStack.Count <= 0)
            {
                Console.WriteLine(0);
                return;
            }
            if (numbersInputStack.Contains(elementToBeFound))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbersInputStack.Min());
            }
        }
    }
}
