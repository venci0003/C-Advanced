using System;
using System.Collections;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
           Stack<int> stack = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                char character = expression[i];
                if (character == '(')
                {
                    stack.Push(i);
                }
                else if (character == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;
                    string subExpression = expression.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(subExpression);
                }
            }
        }
    }
}
