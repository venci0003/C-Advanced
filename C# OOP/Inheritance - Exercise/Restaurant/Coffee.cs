using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private double caffeine;
        public Coffee(string name, double caffeine) : base(name, CoffeePrice, CoffeeMilliliters)
        {
            this.Caffeine = caffeine;
        }

        public const double CoffeeMilliliters = 50;
              
        public const decimal CoffeePrice = 3.50M;
        
        public double Caffeine
        {
            get
            {
                return caffeine;
            }

            set
            {
                caffeine = value;
            }
        }
    }
}
