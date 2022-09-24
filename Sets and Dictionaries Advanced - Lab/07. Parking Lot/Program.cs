using System;
using System.Collections.Generic;
namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            while (true)
            {
                string[] command = Console.ReadLine().ToUpper().Split(", ");
                if (command[0] == "END")
                {
                    break;
                }
                string direction = command[0];
                string carLicensePlateNumber = command[1];

                if (command[0] == "IN")
                {
                    set.Add(carLicensePlateNumber);
                }
                else if (command[0] == "OUT")
                {
                    set.Remove(carLicensePlateNumber);
                }
            }

            if (set.Count <= 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }
            foreach (var licensePlate in set)
            {
                Console.WriteLine(licensePlate);
            }
        }
    }
}
