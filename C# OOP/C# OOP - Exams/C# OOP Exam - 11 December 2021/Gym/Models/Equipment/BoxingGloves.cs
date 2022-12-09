using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Equipment
{
    public class BoxingGloves : Equipment
    {
        private const double WEIGHTS_INCREMENT = 227;

        private const decimal PRICE_INCREMENT = 120;

        public BoxingGloves() : base(WEIGHTS_INCREMENT, PRICE_INCREMENT)
        {
        }
    }
}
