using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isUpperCase = n => char.IsUpper(n[0]);
            Console.WriteLine(string.Join("\n",
                Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Where(n => isUpperCase(n))));
        }
    }
}
