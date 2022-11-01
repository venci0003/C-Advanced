using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Car_Constructors
{
    public class Car
    {
        private string make;

        private string model;

        private int year;

        private double fuelQuantity;

        private double fuelConsumption;


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
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Make: {this.Make}");
            result.AppendLine($"Model: {this.Model}");
            result.AppendLine($"Year: {this.Year}");
            result.AppendLine($"FuelQuantity: {this.FuelQuantity}");

            return result.ToString();
        }
    }
}