namespace VehiclesExtension.Models
{
    public class Car : Vehicle
    {
        private const double FUEL_INCREASEMENT = 0.9;
        public Car(double fuelQuantity, double fuelConsumption,double tankCapacity) : base(fuelQuantity, fuelConsumption + FUEL_INCREASEMENT, tankCapacity)
        {
        }
    }
}
