using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ChristmasPastryShop.Models.Delicacies
{
    public abstract class Delicacy : IDelicacy
    {
        private string name;

        private double price;

        protected Delicacy(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                name = value;
            }
        }

        public double Price
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

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{Name} - {Price:f2} lv");

            return result.ToString().Trim();
        }
    }
}
