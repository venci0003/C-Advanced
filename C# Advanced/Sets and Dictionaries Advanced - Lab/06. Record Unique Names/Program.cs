using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            int forLoops = int.Parse(Console.ReadLine());

            for (int i = 0; i < forLoops; i++)
            {
                string nameInput = Console.ReadLine();
                set.Add(nameInput);
            }

            foreach (var uniqueName in set)
            {
                Console.WriteLine(uniqueName);
            }
        }
    }
}
