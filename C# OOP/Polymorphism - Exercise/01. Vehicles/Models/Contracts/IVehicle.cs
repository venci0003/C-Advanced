namespace Vehicles.Models.Contracts
{
    public interface IVehicle
    {
        double FuelQuantity { get; }
        double FuelConsumption { get; }

        string Drive(double distance);
        void Refuel(double liters);
    }
}
