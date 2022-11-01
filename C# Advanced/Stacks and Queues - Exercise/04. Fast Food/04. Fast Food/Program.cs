using System;
using System.Linq;
using System.Collections.Generic;
namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] foodOrders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> foodOrdersQueue = new Queue<int>(foodOrders);

            int totalSumOfFood = 0;
            Console.WriteLine(foodOrdersQueue.Max());
            while (foodOrdersQueue.Count > 0)
            {
                int currentOrder = foodOrdersQueue.Peek();
                totalSumOfFood += currentOrder;
                if (totalSumOfFood <= quantityOfFood)
                {
                    foodOrdersQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ",foodOrdersQueue)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
