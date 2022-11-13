using Vehicles.Models.Contracts;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {

        protected Vehicle(double fuelQuantity, double fuelConsumption, double fuelConsumptionIncrement)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption + fuelConsumptionIncrement;
        }
        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        public virtual string Drive(double distance)
        {
            double neededFuel = distance * FuelConsumption;
            if (neededFuel > FuelQuantity)
            {
                return $"{GetType().Name} needs refueling";
            }
            else
            {
                FuelQuantity -= neededFuel;
                return $"{GetType().Name} travelled {distance} km";
            }
        }

        public virtual void Refuel(double liters)
        {
            FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
