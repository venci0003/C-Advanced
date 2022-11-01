using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> periodicElements = new HashSet<string>();
            int countOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfInputs; i++)
            {
                string[] elementInput = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                periodicElements.UnionWith(elementInput);
            }

            Console.WriteLine(string.Join(" ",periodicElements.OrderBy(n => n)));
        }
    }
}
