using System;
using System.Linq;
using System.Collections.Generic;
namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
            int[] bottlesWithWater = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> cup = new Stack<int>(cupsCapacity);
            Stack<int> bottle = new Stack<int>(bottlesWithWater);

            int wastedWater = 0;
            while (bottle.Count > 0 && cup.Count > 0)
            {
                int currentBottle = bottle.Pop();
                int currentCup = cup.Pop();

                if (currentCup > currentBottle)
                {
                    int fillUp = currentCup - currentBottle;
                    cup.Push(fillUp);
                }
                else
                {
                    wastedWater += currentBottle - currentCup;
                }
            }
            if (bottle.Count != 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottle)}\nWasted litters of water: {wastedWater}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cup)}\nWasted litters of water: {wastedWater}");
            }
        }
    }
}
