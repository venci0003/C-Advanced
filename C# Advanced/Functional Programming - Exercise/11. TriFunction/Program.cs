using System;
using System.Linq;

namespace _11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> equalOrLargerSum = (name, sum) => name.Sum(character => character) >= sum;

            Func<string[], int, Func<string, int, bool>, string> getFirstName = (names, sum, match) =>
            names.FirstOrDefault(name => match(name, sum));

            int sum = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(getFirstName(names, sum, equalOrLargerSum));
        }
    }
}
