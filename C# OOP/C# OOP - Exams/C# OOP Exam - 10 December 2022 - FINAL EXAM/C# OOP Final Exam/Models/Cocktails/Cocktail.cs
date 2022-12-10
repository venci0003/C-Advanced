using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Text;

namespace ChristmasPastryShop.Models.Cocktails
{
    public abstract class Cocktail : ICocktail
    {
        private string name;

        private string size;

        private double price;

        protected Cocktail(string name, string size, double price)
        {
            Name = name;
            Size = size;
            Price = price;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                name = value;
            }
        }

        public string Size
        {
            get
            {
                return size;
            }
            private set
            {
                
                size = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            private set
            {
                switch (Size)
                {
                    case "Middle":
                        price = 2.0 / 3.0 * value;
                        break;
                    case "Small":
                        price = 1.0 / 3.0 * value;
                        break;
                    default:
                        price = value;
                        break;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append($"{Name} ({Size}) - {Price:f2} lv");

            return result.ToString().Trim();
        }
    }
}
