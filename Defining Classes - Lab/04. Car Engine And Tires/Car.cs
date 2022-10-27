using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;

        private string model;

        private int year;

        private double fuelQuantity;

        private double fuelConsumption;

        private Tire[] tires;

        private Engine engine;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelConsumption = fuelConsumption;
            this.FuelQuantity = fuelQuantity;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,
           Engine engine, Tire[] tires)
           : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
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

        public Engine Engine
        {
            get { return this.engine; }

            set { this.engine = value; }
        }

        public Tire[] Tires
        {
            get { return this.tires; }

            set { this.tires = value; }
        }


        public void Drive(double distance)
        {
            double leftFuel = this.FuelQuantity - distance * this.FuelConsumption;

            if (leftFuel < 0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");

                return;
            }

            else
                this.FuelQuantity = leftFuel;
        }

        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Year: {this.Year}");
            sb.AppendLine($"FuelQuantity: {this.FuelQuantity}");

            return sb.ToString();
        }
    }
}