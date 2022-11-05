using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Food_Shortage
{
    public interface IBuyable
    {
        public string Name { get;}

        public int Food { get; }

        void BuyFood();
    }
}
