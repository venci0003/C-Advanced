namespace WildFarm.Models.Foods
{
    using Interfaces;

    public abstract class Food : IFood
    {
        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; private set; }

        //Only for us, not needed in the problem
        //Run-Time Polymorphism
        public override string ToString()
        {
            return $"{this.GetType().Name} - {this.Quantity}";
        }
    }
}
