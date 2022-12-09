using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms.Contracts;
using Gym.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Models.Gyms
{
    public abstract class Gym : IGym
    {
        private string name;

        private int capacity;

        private List<IEquipment> equipmentInformation;

        private List<IAthlete> athletesInformation;

        protected Gym(string name, int capacity)
        {
            Name = name;

            Capacity = capacity;

            equipmentInformation = new List<IEquipment>();

            athletesInformation = new List<IAthlete>();
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGymName);
                }
                name = value;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
            private set
            {
                capacity = value;
            }
        }

        public double EquipmentWeight => equipmentInformation.Select(e => e.Weight).Sum();

        public ICollection<IEquipment> Equipment => equipmentInformation;

        public ICollection<IAthlete> Athletes => athletesInformation;

        public void AddAthlete(IAthlete athlete)
        {
            if (athletesInformation.Count == Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughSize);
            }
            else
            {
                athletesInformation.Add(athlete);
            }
        }

        public void AddEquipment(IEquipment equipment)
        {
           equipmentInformation.Add(equipment);
        }

        public void Exercise()
        {
            foreach (IAthlete athlete in athletesInformation)
            {
                athlete.Exercise();
            }
        }

        public string GymInfo()
        {
            StringBuilder gymInfo = new StringBuilder();

            gymInfo.AppendLine($"{Name} is a {GetType().Name}:");

            if (athletesInformation.Count > 0)
            {
                gymInfo.AppendLine($"Athletes: {string.Join(", ",athletesInformation.Select(a => a.FullName))}");
            }
            else
            {
                gymInfo.AppendLine("Athletes: No athletes");
            }

            gymInfo.AppendLine($"Equipment total count: {equipmentInformation.Count}");

            gymInfo.AppendLine($"Equipment total weight: {EquipmentWeight:f2} grams");

            return gymInfo.ToString().Trim();
        }

        public bool RemoveAthlete(IAthlete athlete)
        {
            return athletesInformation.Remove(athlete);
        }
    }
}
