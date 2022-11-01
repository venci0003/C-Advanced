using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Raw_Data
{
    public class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.CargoWeight = weight;
            this.Type = type;
        }
        public int CargoWeight { get; set; }
        public string Type { get; set; }
    }
}
