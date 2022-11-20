using System;

namespace VehiclesExtension.Models
{
    public class Truck : Vehicle
    {
        private const double REFUEL_MODIFIER = 0.95;

        private const double FUEL_INCREASEMENT = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption + FUEL_INCREASEMENT, tankCapacity)
        {
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
                Console.WriteLine("Fuel must be a positive number");
            else if (this.fuelQuantity + liters * REFUEL_MODIFIER > this.tankCapacity)
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            else
                base.Refuel(liters * REFUEL_MODIFIER);
        }
    }
}
