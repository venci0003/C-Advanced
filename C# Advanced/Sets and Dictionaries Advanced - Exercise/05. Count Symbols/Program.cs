using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SortedDictionary<char,int> informationOfString = new SortedDictionary<char,int>();

            string stringInput = Console.ReadLine();

            for (int i = 0; i < stringInput.Length; i++)
            {
                char currentChar = stringInput[i];
                if (!informationOfString.ContainsKey(currentChar))
                {
                    informationOfString.Add(currentChar, 0);
                }
                informationOfString[currentChar]++;
            }

            foreach (var character in informationOfString)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
