using System;
using System.Collections.Generic;

namespace _05._Special_Cars
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstCommand = string.Empty;
            List<Tires[]> list = new List<Tires[]>();
            while ((firstCommand = Console.ReadLine()) != "No more tires")
            {
                string[] tokens = firstCommand.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int firstYear = int.Parse(tokens[0]);

                double firstPressure = double.Parse(tokens[1]);

                int secondYear = int.Parse(tokens[2]);

                double secondPressure = double.Parse(tokens[3]);

                int thirdYear = int.Parse(tokens[4]);

                double thirdPressure = double.Parse(tokens[5]);

                int fourthYear = int.Parse(tokens[6]);

                double fourthPressure = double.Parse(tokens[7]);

                Tires[] tireArray = new Tires[4]
                {
                    new Tires(firstYear,secondPressure),

                    new Tires(secondYear,firstPressure),

                    new Tires(thirdYear,thirdPressure),

                    new Tires(fourthYear,fourthPressure),
                };
                list.Add(tireArray);
            }
            string secondCommand = string.Empty;

            List<Engine[]> engineList = new List<Engine[]>();

            while ((secondCommand = Console.ReadLine()) != "Engines done")
            {
                string[] tokens = secondCommand.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int horsePower = int.Parse(tokens[0]);

                double cubicCapacity = double.Parse(tokens[1]);

                Engine[] engineArray = new Engine[1]
                {
                    new Engine(horsePower, cubicCapacity),
                };
                engineList.Add(engineArray);
            }
            string finalCommand = string.Empty;

            List<Car> carList = new List<Car>();

            while ((finalCommand = Console.ReadLine()) != "Show special")
            {
                string[] tokens = finalCommand.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car(tokens[0],
                    tokens[1],
                    int.Parse(tokens[2]),
                    double.Parse(tokens[3]),
                    double.Parse(tokens[4]),
                    int.Parse(tokens[5]),
                    int.Parse(tokens[6]));

                carList.Add(car);
            }
            PrintResult(carList, list, engineList);
        }

        static void PrintResult(List<Car> carList, List<Tires[]> list, List<Engine[]> engineList)
        {
            foreach (Car specialCar in carList)
            {
                Engine[] engineProp = engineList[specialCar.EngineIndex];

                int horsePower = 0;

                double cubicCapacity = 0;

                horsePower = engineProp[0].HorsePower;

                cubicCapacity = engineProp[0].CubicCapacity;

                Engine Engine = new Engine(horsePower, cubicCapacity);

                Tires[] currentTiresArray = list[specialCar.TiresIndex];

                double currentPressureSum = GetSum(currentTiresArray);

                if (specialCar.Year >= 2017 && horsePower > 330 && (currentPressureSum > 9 && currentPressureSum < 10))
                {
                    specialCar.FuelQuantity = specialCar.Drive20Kilometers(specialCar.FuelQuantity, specialCar.FuelConsumption);

                    Console.WriteLine($"Make: {specialCar.Make}");

                    Console.WriteLine($"Model: {specialCar.Model}");

                    Console.WriteLine($"Year: {specialCar.Year}");

                    Console.WriteLine($"HorsePowers: {horsePower}");

                    Console.WriteLine($"FuelQuantity: {specialCar.FuelQuantity}");
                }
            }
        }

        static double GetSum(Tires[] currentTiresArray)
        {
            double sum = 0;
            for (int i = 0; i < currentTiresArray.Length; i++)
            {
                sum += currentTiresArray[i].Pressure;
            }
            return sum;
        }
    }
}