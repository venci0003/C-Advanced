using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Fish
{
    public class SaltwaterFish : Fish
    {
        public SaltwaterFish(string name, string species, decimal price) : base(name, species, price)
        {
            Size = 5;
        }

        public override void Eat()
        {
            Size += 2;
        }
    }
}
