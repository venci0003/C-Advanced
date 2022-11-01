namespace NeedForSpeed
{
    public class Vehicle
    {

        public Vehicle(int horsePower , double fuel)
        {
            this.Fuel = fuel;
            this.HorsePower = horsePower;
        }
        public const double DefaultFuelConsumption = 1.25;

        public virtual double FuelConsumption => DefaultFuelConsumption;

        public double Fuel { get; set; }

        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            if (this.Fuel - (this.FuelConsumption * kilometers) >= 0)
            {
                this.Fuel -= this.FuelConsumption * kilometers;
            }
        }
    }
}
