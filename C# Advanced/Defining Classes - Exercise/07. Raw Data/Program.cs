using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                Engine engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                Cargo cargo = new Cargo(int.Parse(input[3]), input[4]);
                double pressure1 = double.Parse(input[5]);
                int age1 = int.Parse(input[6]);
                double pressure2 = double.Parse(input[7]);
                int age2 = int.Parse(input[8]);
                double pressure3 = double.Parse(input[9]);
                int age3 = int.Parse(input[10]);
                double pressure4 = double.Parse(input[11]);
                int age4 = int.Parse(input[12]);
                Tires[] tiresArray = new Tires[4]
                {
                   new Tires(pressure1,age1),
                   new Tires(pressure2,age2),
                   new Tires(pressure3,age3),
                   new Tires(pressure4,age4)
                };
                Car car = new Car(model, engine, cargo, tiresArray);
                cars.Add(car);
            }
            string type = Console.ReadLine();
            PrintResult(cars, type);
        }

        static void PrintResult(List<Car> cars, string type)
        {
            if (type == "fragile")
            {
                foreach (Car car in cars.Where(x => x.Cargo.Type == "fragile"))
                {
                    for (int i = 0; i < car.Tires.Length; i++)
                    {
                        Tires current = car.Tires[i];
                        double pressure = current.Presusre;
                        if (pressure < 1)
                        {
                            Console.WriteLine(car.Model);
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (Car car in cars.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
