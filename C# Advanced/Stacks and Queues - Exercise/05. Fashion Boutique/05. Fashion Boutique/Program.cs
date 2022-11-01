using System;
using System.Linq;
using System.Collections.Generic;
namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothesBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> clothesBoxStack = new Stack<int>(clothesBox);
            int rackCapacity = int.Parse(Console.ReadLine());
            int clothesSum = 0;
            int rackCount = 1;

            while (clothesBoxStack.Count > 0)
            {
                int currentClothesBox = clothesBoxStack.Peek();
                clothesSum += currentClothesBox;
                if (clothesSum <= rackCapacity)
                {
                    clothesBoxStack.Pop();
                }
                else
                {
                    rackCount++;
                    clothesSum = 0;
                }
            }
            Console.WriteLine(rackCount);
        }
    }
}
