using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int loops = int.Parse(Console.ReadLine());
            for (int i = 0; i < loops; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list.Add(input);
            }
            int[] indexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            Swap(list, indexes);

            foreach (int item in list)
            {
                Box<int> box = new Box<int>(item);
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
