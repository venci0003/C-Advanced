using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbersToBeSolved = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < numbersToBeSolved.Length; i++)
            {
                stack.Push(numbersToBeSolved[i]);

                if (stack.Count == 3)
                {
                    int first = int.Parse(stack.Pop());
                    var sign = stack.Pop();
                    int second = int.Parse(stack.Pop());
                    int result = 0;
                    if (sign == "+")
                    {
                        result = first + second;
                    }
                    if (sign == "-")
                    {
                        result = second - first;
                    }

                    stack.Push(result.ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
