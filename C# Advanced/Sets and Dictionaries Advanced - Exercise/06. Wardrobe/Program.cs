using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string,int>> clothesByColour = new Dictionary<string,Dictionary<string,int>>();

            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(new string[] {" -> ", ",", },StringSplitOptions.RemoveEmptyEntries);

                string keyColour = tokens[0];
                if (!clothesByColour.ContainsKey(keyColour))
                {
                    clothesByColour[keyColour] = new Dictionary<string, int>();
                }
                for (int j = 1; j < tokens.Length; j++)
                {
                    string currentClothing = tokens[j];
                    if (!clothesByColour[keyColour].ContainsKey(currentClothing))
                    {
                        clothesByColour[keyColour].Add(currentClothing, 0);
                    }
                    clothesByColour[keyColour][currentClothing]++;
                }
            }

            string[] findClothes = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

            foreach (var garment in clothesByColour)
            {
                Console.WriteLine($"{garment.Key} clothes:");
                foreach (var currentGarment in garment.Value)
                {
                    string printItem = $"* {currentGarment.Key} - {currentGarment.Value}";
                    if (garment.Key == findClothes[0] && currentGarment.Key == findClothes[1])
                    {
                        printItem += " (found!)";
                    }

                    Console.WriteLine(printItem);
                }
            }
        }
    }
}
