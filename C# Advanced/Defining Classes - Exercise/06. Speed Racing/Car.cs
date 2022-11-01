using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Speed_Racing
{
    public class Car
    {
        private string model;

        private double fuelAmount;

        private double fuelConsumptionPerKilometer;

        private double travelledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }
        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }
        }

        public double FuelAmount
        {
            get
            {
                return this.fuelAmount;
            }

            set
            {
                this.fuelAmount = value;
            }
        }

        public double FuelConsumptionPerKilometer
        {
            get
            {
                return this.fuelConsumptionPerKilometer;
            }

            set
            {
                this.fuelConsumptionPerKilometer = value;
            }
        }

        public double TravelledDistance
        {
            get
            {
                return this.travelledDistance;
            }

            set
            {
                this.travelledDistance = value;
            }
        }

        public void Drive(string carModel, double kilometersToDrive)
        {
            double fuelNeeded = fuelConsumptionPerKilometer * kilometersToDrive;
            if (this.FuelAmount >= fuelNeeded)
            {
                this.TravelledDistance += kilometersToDrive;
                this.FuelAmount -= FuelConsumptionPerKilometer * kilometersToDrive;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
