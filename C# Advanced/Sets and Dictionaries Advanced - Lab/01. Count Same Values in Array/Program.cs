using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double,int> numbersInformation = new Dictionary<double,int>();
            double[] numbers = Console.ReadLine().Split().Select(n => double.Parse(n)).ToArray();

            foreach (double number in numbers)
            {
                if (!numbersInformation.ContainsKey(number))
                {
                    numbersInformation.Add(number, 0);
                    numbersInformation[number]++;
                }
                else
                {
                    numbersInformation[number]++;
                }
            }
            foreach (var numberInfo in numbersInformation)
            {
                Console.WriteLine($"{numberInfo.Key} - {numberInfo.Value} times");
            }
        }
    }
}
