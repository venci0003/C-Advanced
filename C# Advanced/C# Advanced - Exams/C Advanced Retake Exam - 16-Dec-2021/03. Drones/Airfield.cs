using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        private List<Drone> Drones;

        private string name;
        private int capacity;
        private double landingStrip;

        public Airfield(string name, int capacity, double landingStrip)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.LandingStrip = landingStrip;
            this.Drones = new List<Drone>();
        }

        public double LandingStrip
        {
            get { return landingStrip; }
            set { landingStrip = value; }
        }


        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Count { get { return this.Drones.Count; } private set { } }

        public string AddDrone(Drone drone)
        {
            if (string.IsNullOrEmpty(drone.Name) || string.IsNullOrEmpty(drone.Brand))
            {
                return "Invalid drone.";
            }
            if (drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone.";
            }
            if (this.Capacity - this.Drones.Capacity > 0)
            {
                Drones.Add(drone);
                return $"Successfully added {drone.Name} to the airfield.";
            }
            else
            {
                return "Airfield is full.";
            }
        }

        public bool RemoveDrone(string name)
        {
            bool exists = false;

            Drone droneToRemove = this.Drones.FirstOrDefault(n => n.Name == name);

            if (droneToRemove != null)
            {
                exists = true;
                this.Drones.Remove(droneToRemove);
            }
            return exists;
        }

        public int RemoveDroneByBrand(string brand)
        {
            int countOfRemovedDrones = 0;

            for (int i = 0; i < this.Drones.Count; i++)
            {
                Drone currentDrone = Drones[i];
                if (currentDrone.Brand == brand)
                {
                    this.Drones.Remove(currentDrone);
                    i--;
                    countOfRemovedDrones++;
                }
            }

            return countOfRemovedDrones;
        }

        public Drone FlyDrone(string name)
        {
            Drone droneToSet = this.Drones.FirstOrDefault(x => x.Name == name);
            if (droneToSet != null)
            {
                droneToSet.Available = false;
                return droneToSet;
            }
            else
            {
                return null;
            }
        }
        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> dronesByRange = this.Drones.Where(d => d.Range >= range && d.Available != false).ToList();
            for (int i = 0; i < dronesByRange.Count; i++)
            {
                Drone currentDron = dronesByRange[i];
                currentDron.Available = false;
            }
            return dronesByRange;
        }
        public string Report()
        {
            StringBuilder report = new StringBuilder();
            report.AppendLine($"Drones available at {this.Name}:");
            foreach (Drone item in this.Drones.Where(d => d.Available != false))
            {
                report.AppendLine(item.ToString());
            }
            return report.ToString().Trim();
        }
    }
}
