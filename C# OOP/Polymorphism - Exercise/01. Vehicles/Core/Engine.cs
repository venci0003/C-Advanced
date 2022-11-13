namespace Vehicles.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Vehicles.Core.Interfaces;
    using Vehicles.Factories.Interfaces;
    using Vehicles.IO.Interfaces;
    using Vehicles.Models.Contracts;

    public class Engine : IEngine
    {
        private readonly IReader reader;

        private readonly IWriter writer;

        private readonly IVehicleFactory vehicleFactory;

        private readonly ICollection<IVehicle> vehicles;

        //private IVehicle car;

        //private IVehicle truck;

        public Engine()
        {
            this.vehicles = new List<IVehicle>();
        }

        public Engine(IReader reader, IWriter writer,IVehicleFactory vehicleFactory) : this()
        {
            this.reader = reader;
            this.writer = writer;
            this.vehicleFactory = vehicleFactory;
        }

        public void Run()
        {
            this.vehicles.Add(this.BuildVehicleUsingFactory());

            this.vehicles.Add(this.BuildVehicleUsingFactory());

            int loops = int.Parse(this.reader.ReadLine());

            for (int i = 0; i < loops; i++)
            {
                string[] cmdArgs = this.reader.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                string vehicleType = cmdArgs[1];

                double arg = double.Parse(cmdArgs[2]);

                IVehicle vehicleToProcess = this.vehicles.FirstOrDefault(v => v.GetType().Name == vehicleType);

                if (cmdType == "Drive")
                {
                    this.writer.WriteLine(vehicleToProcess.Drive(arg));
                }
                else if (cmdType == "Refuel")
                {
                    vehicleToProcess.Refuel(arg);
                }
            }

            this.PrintAllVehicles();
        }
        private IVehicle BuildVehicleUsingFactory()
        {
            string[] vehicleArgs = this.reader.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string vehicleType = vehicleArgs[0];

            double vehicleFuelQuantity = double.Parse(vehicleArgs[1]);

            double vehicleFuelConsumption = double.Parse(vehicleArgs[2]);

            IVehicle vehicle = this.vehicleFactory.CreateVehicle(vehicleType, vehicleFuelQuantity, vehicleFuelConsumption);

            return vehicle;
        }

        private void PrintAllVehicles()
        {
            foreach (IVehicle vehicle in this.vehicles)
            {
                this.writer.WriteLine(vehicle.ToString());
            }
        }
    }
}
