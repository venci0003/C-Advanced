using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continentInformation = new Dictionary<string, Dictionary<string, List<string>>>();
            int forLoopCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < forLoopCount; i++)
            {

                string[] command = Console.ReadLine().Split();

                string continentName = command[0];
                string countryName = command[1];
                string citiesInCountry = command[2];

                if (!continentInformation.ContainsKey(continentName))
                {
                    continentInformation[continentName] = new Dictionary<string, List<string>>();
                }
                if (!continentInformation[continentName].ContainsKey(countryName))
                {
                    continentInformation[continentName].Add(countryName, new List<string>());
                }
                continentInformation[continentName][countryName].Add(citiesInCountry);
            }

            foreach (var continent in continentInformation)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var countryInformation in continent.Value)
                {
                    Console.WriteLine($"{countryInformation.Key} -> {string.Join(", ", countryInformation.Value)}");
                }
            }
        }
    }
}
