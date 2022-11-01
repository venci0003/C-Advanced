using System;

namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Action<string[]> print = n => Console.WriteLine(string.Join("\n",n));

            string[] input = Console.ReadLine().Split();
            print(input);
        }
    }
}
