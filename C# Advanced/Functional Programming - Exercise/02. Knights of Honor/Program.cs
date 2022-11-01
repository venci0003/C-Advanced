using System;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = n => Console.WriteLine($"Sir {n}");

            string[] input = Console.ReadLine().Split();
            foreach (string name in input)
            {
                print(name);
            }
        }
    }
}
