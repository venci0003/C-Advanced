using System;
using System.Collections.Generic;

namespace _08._Car_Salesman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfEngines = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                int displacement = 0;

                string efficiency = " ";

                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int index = 0;

                string model = tokens[0];

                index++;

                int power = int.Parse(tokens[1]);

                index++;

                if (index < tokens.Length)
                {
                    int number;

                    bool success = int.TryParse(tokens[index], out number);

                    if (success)
                    {
                        displacement = int.Parse(tokens[index]);

                        index++;
                    }
                }
                if (index < tokens.Length)
                {
                    efficiency = tokens[index];

                    index++;
                }
                Engine engine = new Engine(model, power, displacement, efficiency);
                engines.Add(engine);
            }
            List<Car> cars = new List<Car>();

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string color = " ";

                int weight = 0;

                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int index = 0;

                string model = tokens[0];

                index++;

                string engineModel = tokens[1];

                index++;

                if (index < tokens.Length)
                {
                    int number;

                    bool success = int.TryParse(tokens[index], out number);

                    if (success)
                    {
                        weight = int.Parse(tokens[index]);

                        index++;
                    }
                }
                if (index < tokens.Length)
                {
                    color = tokens[index];
                }

                Engine engineToFind = engines.Find(x => x.Model == engineModel);

                Car car = new Car(model, engineToFind, weight, color);

                cars.Add(car);
            }
            PrintResult(cars);
        }

        static void PrintResult(List<Car> cars)
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model}:");

                Console.WriteLine($"  {car.Engine.Model}:");

                Console.WriteLine($"  Power: {car.Engine.Power}");

                if (car.Engine.Displacement != 0)
                {
                    Console.WriteLine($"  Displacement: {car.Engine.Displacement}");
                }
                else
                {
                    Console.WriteLine("  Displacement: n/a");
                }
                if (car.Engine.Efficiency != " ")
                {
                    Console.WriteLine($"  Efficiency: {car.Engine.Efficiency}");
                }
                else
                {
                    Console.WriteLine("  Efficiency: n/a");
                }

                if (car.Weight != 0)
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                else
                {
                    Console.WriteLine("  Weight: n/a");
                }
                if (car.Color != " ")
                {
                    Console.WriteLine($"  Color: {car.Color}");
                }
                else
                {
                    Console.WriteLine("  Color: n/a");
                }
            }
        }
    }
}
