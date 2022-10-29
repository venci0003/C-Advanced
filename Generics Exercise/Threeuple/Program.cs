using System;
using System.Linq;

namespace Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[]secondaryTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string city = string.Join(" ", personTokens.Skip(3));

            Threeuple<string, string, string> personInfo = new Threeuple<string, string, string>
            {
                FirstValue = $"{personTokens[0]} {personTokens[1]}",

                SecondValue = personTokens[2],

                ThirdValue = city
            };
            Threeuple<string, int, bool> personInfo2 = new Threeuple<string, int, bool>
            {
                FirstValue = tokens[0],

                SecondValue = int.Parse(tokens[1]),

                ThirdValue = tokens[2] == "drunk"
            };
            Threeuple<string, double, string> personInfo3 = new Threeuple<string, double, string>
            {
                FirstValue = secondaryTokens[0],

                SecondValue = double.Parse(secondaryTokens[1]),

                ThirdValue = secondaryTokens[2]
            };
            Console.WriteLine($"{personInfo}\n{personInfo2}\n{personInfo3}");
        }
    }
}
