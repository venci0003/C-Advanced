using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Delicacies
{
    public class Stolen : Delicacy
    {
        private const double CONST_STOLEN_PRICE = 3.50;

        public Stolen(string name) : base(name, CONST_STOLEN_PRICE)
        {
        }
    }
}
