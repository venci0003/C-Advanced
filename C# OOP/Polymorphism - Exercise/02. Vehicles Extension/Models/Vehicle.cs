using System;
using VehiclesExtension.Models;

namespace VehiclesExtension.Models
{
    public abstract class Vehicle
    {
        protected double fuelQuantity;
        protected double fuelConsumption;
        protected double tankCapacity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.fuelConsumption = fuelConsumption;
            this.tankCapacity = tankCapacity;

            if (fuelQuantity <= tankCapacity)
                this.fuelQuantity = fuelQuantity;
        }

        public virtual void Drive(double distance)
        {
            double neededFuel = this.fuelQuantity - this.fuelConsumption * distance;
            if (neededFuel < 0)
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
            else
            {
                this.fuelQuantity = neededFuel;
                Console.WriteLine($"{GetType().Name} travelled {distance} km");
            }
        }

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (this.fuelQuantity + liters < this.tankCapacity)
            {
                this.fuelQuantity += liters;
            }
            else
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.fuelQuantity:f2}";
        }
    }
}
