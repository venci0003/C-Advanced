using Gym.Models.Equipment.Contracts;
using Gym.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Equipment
{
    public abstract class Equipment : IEquipment
    {
        private double weight;

        private decimal price;

        protected Equipment(double weight, decimal price)
        {
            Weight = weight;
            Price = price;
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            private set
            {
                weight = value;
            }
        }


        public decimal Price
        {
            get
            {
                return price;
            }
            private set
            {
                price = value;
            }
        }
    }
}
