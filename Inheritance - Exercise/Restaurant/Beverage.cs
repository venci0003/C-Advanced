using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Beverage : Product
    {
        private double milliliters;
        public Beverage(string name, decimal price, double milliliters) : base(name, price)
        {
            this.Milliliters = milliliters;
        }

        public double Milliliters
        {
            get
            {
                return milliliters;
            }
            set
            {
                milliliters = value;
            }
        }
    }
}
