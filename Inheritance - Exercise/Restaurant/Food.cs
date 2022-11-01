using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace Restaurant
{
    public class Food : Product
    {
        private double grams;
        public Food(string name, decimal price,double grams) : base(name, price)
        {
            this.Name = name;
            this.Price = price;
            this.Grams = grams;
        }

        public double Grams
        {
            get
            {
                return grams;
            }
            set
            {
                grams = value;
            }
        }
    }
}
