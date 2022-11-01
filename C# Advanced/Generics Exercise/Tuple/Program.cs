using System;

namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] drinkTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Tuple<string, string> firstTyple = new Tuple<string, string>();

            firstTyple.FirstValue = $"{personTokens[0]} {personTokens[1]}";

            firstTyple.SecondValue = personTokens[2];

            Tuple<string, int> nameBeer = new Tuple<string, int>
            {
                FirstValue = drinkTokens[0],

                SecondValue = int.Parse(drinkTokens[1])
            };
            Tuple<int, double> thirdTuple = new Tuple<int, double>
            {
                FirstValue = int.Parse(tokens[0]),

                SecondValue = double.Parse(tokens[1])
            };
            Console.WriteLine(firstTyple);

            Console.WriteLine(nameBeer);

            Console.WriteLine(thirdTuple);
        }
    }
}
