using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Plant : Decoration
    {
        private const int COMFORT_INCREMENT = 5;

        private const decimal PRICE_INCREMENT = 10;
        public Plant() : base(COMFORT_INCREMENT, PRICE_INCREMENT)
        {
        }

        public Plant(int comfort, decimal price) : base(comfort, price)
        {
        }
    }
}
