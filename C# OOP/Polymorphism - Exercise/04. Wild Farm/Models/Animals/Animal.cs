namespace WildFarm.Models.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Exceptions;
    using Interfaces;

    public abstract class Animal : IAnimal
    {
        //This can be omitted since default value of int is 0
        //Compile-Time Polymorphism
        private Animal()
        {
            this.FoodEaten = 0;
        }

        protected Animal(string name, double weight)
            : this()
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        protected abstract double WeightMultiplier { get; }

        public abstract IReadOnlyCollection<Type> PreferredFoods { get; }

        public abstract string ProduceSound();

        public void Eat(IFood food)
        {
            if (!this.PreferredFoods.Any(dt => food.GetType().Name == dt.Name))
            {
                throw new FoodNotEatenException(string.Format(
                    ExceptionMessages.FoodNotEatenExceptionMessage, this.GetType().Name, food.GetType().Name));
            }

            this.Weight += food.Quantity * this.WeightMultiplier;
            this.FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
