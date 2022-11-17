namespace WildFarm.Models.Animals
{
    using Interfaces;

    public abstract class Bird : Animal, IBird
    {
        protected Bird(string name, double weight, double wingSize)
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get; private set; }

        public override string ToString()
        {
            return base.ToString() + 
                $"{this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
