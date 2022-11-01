using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Car_Salesman
{
    public class Engine
    {
        public Engine(string model, int power, int displacment, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacment;
            this.Efficiency = efficiency;
        }
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }
    }
}
