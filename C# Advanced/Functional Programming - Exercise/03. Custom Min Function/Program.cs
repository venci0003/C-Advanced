using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> minValue = (numbers) => 
            {
                int min = int.MaxValue;

                foreach (var number in numbers)
                {
                    if (number < min)
                    {
                        min = number;
                    }
                }
                return min;
            };

            int[] numbersInput = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();

            Console.WriteLine(minValue(numbersInput));
        }
    }
}
