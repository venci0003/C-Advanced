namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double fuelConsumptionIncrement = 0.9;
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption, fuelConsumptionIncrement)
        {
        }
    }
}
