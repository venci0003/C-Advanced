using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int loops = int.Parse(Console.ReadLine());
            for (int i = 0; i < loops; i++)
            {
                string input = Console.ReadLine();
                list.Add(input);
            }
            int[] indexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            Swap(list, indexes);

            foreach (string item in list)
            {
                Box<string>box = new Box<string>(item);

                Console.WriteLine(box);
            }
        }
        static void Swap<T>(List<T> list, int[] indexes)
        {
            int firstInex = indexes[0];

            int secondIndex = indexes[1];

            T firstElement = list[firstInex];

            list[firstInex] = list[secondIndex];

            list[secondIndex] = firstElement;
        }
    }
}
