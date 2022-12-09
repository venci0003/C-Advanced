using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Equipment
{
    public class Kettlebell : Equipment
    {
        private const double WEIGHTS_INCREMENT = 10000;

        private const decimal PRICE_INCREMENT = 80;
        public Kettlebell() : base(WEIGHTS_INCREMENT, PRICE_INCREMENT)
        {
        }
    }
}
