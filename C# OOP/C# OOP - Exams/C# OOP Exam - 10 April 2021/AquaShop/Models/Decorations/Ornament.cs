using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Ornament : Decoration
    {
        private const int COMFORT_INCREMENT = 1;

        private const decimal PRICE_INCREMENT = 5;

        public Ornament() : base(COMFORT_INCREMENT,PRICE_INCREMENT)
        {
        }
    }
}
