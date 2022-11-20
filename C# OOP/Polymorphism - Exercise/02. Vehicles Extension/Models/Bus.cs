namespace VehiclesExtension.Models
{
    public class Bus : Vehicle
    {
        private const double FUEL_INCREASEMENT = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            base.fuelConsumption += FUEL_INCREASEMENT;
            base.Drive(distance);
            base.fuelConsumption -= FUEL_INCREASEMENT;
        }

        public void DriveEmpty(double distance)
        {
            base.Drive(distance);
        }
    }
}
