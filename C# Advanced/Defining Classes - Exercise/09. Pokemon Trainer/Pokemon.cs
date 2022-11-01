using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._Pokemon_Trainer
{
    public class Pokemon
    {
        public Pokemon(string name, string element, int health)
        {
          this.Name = name;
          this.Element = element;
          this.Health = health;
        }

        public string Name { get; set; }
        public string Element { get; set; }
        public int Health { get; set; }
    }
}
