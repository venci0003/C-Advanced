using System;
using System.Linq;
using System.Collections.Generic;
namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            int[] amountOfBullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] amountOfLocks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligenceValue = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(amountOfBullets);
            Queue<int> locks = new Queue<int>(amountOfLocks);

            int shotsFired = 0;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                int currentBullet = bullets.Pop();
                shotsFired++;
                int currentLock = locks.Peek();
                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (shotsFired % sizeOfGunBarrel == 0 && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }
            int finalReward = intelligenceValue - (shotsFired * bulletPrice);
           
            if (locks.Count <= 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${finalReward}");
            }
            else if (locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
