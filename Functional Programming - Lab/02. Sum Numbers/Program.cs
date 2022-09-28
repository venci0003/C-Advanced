using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parseFunction = n => int.Parse(n);
            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(parseFunction)
                .ToArray();

            Console.WriteLine(input.Length);
            Console.WriteLine(input.Sum());
        }
    }
}
