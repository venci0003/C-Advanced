using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    internal class SaltwaterAquarium : Aquarium
    {
        private const int CAPACITY_INCREMENT = 25;
        public SaltwaterAquarium(string name) : base(name, CAPACITY_INCREMENT)
        {
        }
    }
}
