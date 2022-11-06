using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private string favouriteFood;

        public Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public string Name
        {
            get 
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string FavouriteFood
        {
            get
            {
                return favouriteFood;
            }
            set
            {
                favouriteFood = value;
            }
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
        }
    }
}
