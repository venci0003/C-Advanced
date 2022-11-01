using System;
using System.Linq;
using System.Collections.Generic;
namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parantheses = Console.ReadLine();
            Stack<char> paranthesesInQueue = new Stack<char>();

            foreach (var paranthese in parantheses)
            {
                if (paranthese == '}' && paranthesesInQueue.Any())
                {
                    char currentParanthese = paranthesesInQueue.Pop();
                    if (currentParanthese == '{')
                    {
                        continue;
                    }
                    else
                    {
                        paranthesesInQueue.Push(currentParanthese);
                    }
                }
                else if (paranthese == ']' && paranthesesInQueue.Any())
                {
                    char currentParanthese = paranthesesInQueue.Pop();
                    if (currentParanthese == '[')
                    {
                        continue;
                    }
                    else
                    {
                        paranthesesInQueue.Push(currentParanthese);
                    }
                }
                else if (paranthese == ')' && paranthesesInQueue.Any())
                {
                    char currentParanthese = paranthesesInQueue.Pop();
                    if (currentParanthese == '(')
                    {
                        continue;
                    }
                    else
                    {
                        paranthesesInQueue.Push(currentParanthese);
                    }
                }
                else
                {
                    paranthesesInQueue.Push(paranthese);
                }
            }
            if (paranthesesInQueue.Count <= 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
