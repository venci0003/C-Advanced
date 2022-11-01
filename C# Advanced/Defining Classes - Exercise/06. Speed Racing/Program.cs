using System;
using System.Collections.Generic;

namespace _06._Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();

            int forLoops = int.Parse(Console.ReadLine());

            for (int i = 0; i < forLoops; i++)
            {
                string command = Console.ReadLine();

                string[] input = command.Split();

                Car newCar = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
                carList.Add(newCar);
            }


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] input = command.Split();


                if (input[0] == "Drive")
                {
                    string carModel = input[1];
                    double kilometersToDrive = double.Parse(input[2]);
                    Car carToBeDriven = carList.Find(x => x.Model == carModel);
                    carToBeDriven.Drive(carModel, kilometersToDrive);
                }
            }

            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
