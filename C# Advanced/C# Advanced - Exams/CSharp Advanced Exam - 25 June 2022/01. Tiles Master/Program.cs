using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Tiles_Master
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] whiteTiles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] greyTiles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> greyTilesQuantity = new Queue<int>(greyTiles);

            Stack<int> whiteTilesQuantity = new Stack<int>(whiteTiles);

            Dictionary<string, int> kitchenInformation = new Dictionary<string, int>();

            int areaSum = 0;

            string currentLocation = string.Empty;

            while (greyTilesQuantity.Any() && whiteTilesQuantity.Any())
            {
                int currentGreyTile = greyTilesQuantity.Dequeue();
                int currentWhiteTile = whiteTilesQuantity.Pop();
                if (currentGreyTile == currentWhiteTile)
                {
                    areaSum = currentGreyTile + currentWhiteTile;
                }
                else
                {
                    whiteTilesQuantity.Push(currentWhiteTile /= 2);
                    greyTilesQuantity.Enqueue(currentGreyTile);

                    continue;
                }


                if (areaSum == 40)
                {
                    currentLocation = "Sink";
                    if (!kitchenInformation.ContainsKey(currentLocation))
                    {
                        kitchenInformation.Add(currentLocation, 0);
                    }
                    kitchenInformation[currentLocation]++;
                }
                else if (areaSum == 50)
                {
                    currentLocation = "Oven";
                    if (!kitchenInformation.ContainsKey(currentLocation))
                    {
                        kitchenInformation.Add(currentLocation, 0);
                    }
                    kitchenInformation[currentLocation]++;
                }
                else if (areaSum == 60)
                {
                    currentLocation = "Countertop";
                    if (!kitchenInformation.ContainsKey(currentLocation))
                    {
                        kitchenInformation.Add(currentLocation, 0);
                    }
                    kitchenInformation[currentLocation]++;
                }
                else if (areaSum == 70)
                {
                    currentLocation = "Wall";
                    if (!kitchenInformation.ContainsKey(currentLocation))
                    {
                        kitchenInformation.Add(currentLocation, 0);
                    }
                    kitchenInformation[currentLocation]++;
                }
                else
                {
                    currentLocation = "Floor";
                    if (!kitchenInformation.ContainsKey(currentLocation))
                    {
                        kitchenInformation.Add(currentLocation, 0);
                    }
                    kitchenInformation[currentLocation]++;
                }
            }

            if (whiteTilesQuantity.Count <= 0)
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: {string.Join(", ",whiteTilesQuantity)}");
            }

            if (greyTilesQuantity.Count <= 0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTilesQuantity)}");
            }

            foreach (var location in kitchenInformation.OrderByDescending(n => n.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{location.Key}: {location.Value}");
            }
        }
    }
}
