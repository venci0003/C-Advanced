namespace Vehicles.Factories
{
    using System;
    using Vehicles.Factories.Interfaces;
    using Vehicles.Models;
    using Vehicles.Models.Contracts;
    public class VehicleFactory : IVehicleFactory
    {
        public VehicleFactory()
        {

        }
        public IVehicle CreateVehicle(string type, double fuelQuantity, double fuelConsumption)
        {
            IVehicle vehicle;

            if (type == "Car")
            {
                vehicle = new Car(fuelQuantity, fuelConsumption);
            }
            else if (type == "Truck")
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption);
            }
            else
            {
                throw new FormatException("Vehicle type not supported");
            }

            return vehicle;
        }
    }
}
