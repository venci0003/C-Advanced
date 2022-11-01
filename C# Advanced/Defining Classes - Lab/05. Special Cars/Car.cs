using System;

namespace _05._Special_Cars
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private int engineIndex;
        private int tiresIndex;
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, int engineIndex, int tiresIndex)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.EngineIndex = engineIndex;
            this.TiresIndex = tiresIndex;
        }
     
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public int HorsePower
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }
        public int EngineIndex
        {
            get { return this.engineIndex; }
            set { this.engineIndex = value; }
        }

        public int TiresIndex
        {
            get { return this.tiresIndex; }
            set { this.tiresIndex = value; }
        }

        public double TotalPressure { get; set; }


        public double Drive20Kilometers(double fuelQuantity, double fuelConsumption)
        {
            fuelQuantity -= (FuelConsumption / 100) * 20;

            return fuelQuantity;
        }
    }
}