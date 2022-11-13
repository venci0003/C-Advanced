namespace Vehicles.Factories.Interfaces
{
using Vehicles.Models.Contracts;
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(string type, double fuelQuantity, double fuelConsumption);
    }
}
