using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] steelInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] carbonInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> steel = new Queue<int>(steelInput);

            Stack<int> carbon = new Stack<int>(carbonInput);

            Dictionary<string, int> weaponsInformation = new Dictionary<string, int>();

            string currentWeapon = string.Empty;

            int swordsCount = 0;

            while (steel.Any() && carbon.Any())
            {
                int currentSteel = steel.Peek();

                int currentCarbon = carbon.Peek();

                int sum = currentCarbon + currentSteel;

                if (sum == 70)
                {
                    currentWeapon = "Gladius";
                    if (!weaponsInformation.ContainsKey(currentWeapon))
                    {
                        weaponsInformation[currentWeapon] = 0;
                    }
                    weaponsInformation[currentWeapon]++;

                    swordsCount++;

                    steel.Dequeue();
                    carbon.Pop();
                }
                else if (sum == 80)
                {
                    currentWeapon = "Shamshir";
                    if (!weaponsInformation.ContainsKey(currentWeapon))
                    {
                        weaponsInformation[currentWeapon] = 0;
                    }
                    weaponsInformation[currentWeapon]++;

                    swordsCount++;

                    steel.Dequeue();
                    carbon.Pop();
                }
                else if (sum == 90)
                {
                    currentWeapon = "Katana";
                    if (!weaponsInformation.ContainsKey(currentWeapon))
                    {
                        weaponsInformation[currentWeapon] = 0;
                    }
                    weaponsInformation[currentWeapon]++;

                    swordsCount++;

                    steel.Dequeue();
                    carbon.Pop();
                }
                else if (sum == 110)
                {
                    currentWeapon = "Sabre";
                    if (!weaponsInformation.ContainsKey(currentWeapon))
                    {
                        weaponsInformation[currentWeapon] = 0;
                    }
                    weaponsInformation[currentWeapon]++;

                    swordsCount++;

                    steel.Dequeue();
                    carbon.Pop();
                }
                else if (sum == 150)
                {
                    currentWeapon = "Broadsword";
                    if (!weaponsInformation.ContainsKey(currentWeapon))
                    {
                        weaponsInformation[currentWeapon] = 0;
                    }
                    weaponsInformation[currentWeapon]++;

                    swordsCount++;

                    steel.Dequeue();
                    carbon.Pop();
                }
                else
                {
                    steel.Dequeue();
                    int carbonToRemove = carbon.Pop();
                    carbon.Push(carbonToRemove + 5);
                }
            }

            Print(swordsCount, carbon, steel, weaponsInformation);
        }

        private static void Print(int swordsCount, Stack<int> carbon, Queue<int> steel, Dictionary<string, int> weaponsInformation)
        {
            if (swordsCount > 0)
            {
                Console.WriteLine($"You have forged {swordsCount} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }

            if (steel.Count > 0)
            {
                Console.WriteLine($"Steel left: {string.Join(", ", steel)}");
            }
            else
            {
                Console.WriteLine("Steel left: none");
            }

            if (carbon.Count > 0)
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbon)}");
            }
            else
            {
                Console.WriteLine("Carbon left: none");
            }

            foreach (var weapon in weaponsInformation.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{weapon.Key}: {weapon.Value}");
            }
        }
    }
}
