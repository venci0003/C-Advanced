using System;
using System.Collections.Generic;

namespace _05._Special_Cars
{
    public class Engine
    {
        public int HorsePower { get; set; }

        public double CubicCapacity { get; set; }
        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }
    }
}
