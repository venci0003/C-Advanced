namespace P04.Recharge.Models
{
    using System;
    using Contracts;
    public class Robot : Worker, IRechargeable
    {
        private int capacity;
        private int currentPower;

        public Robot(string id, int capacity) : base(id)
        {
            this.capacity = capacity;
        }

        public int Capacity
        {
            get { return capacity; }
        }

        public int CurrentPower
        {
            get { return currentPower; }
            set { currentPower = value; }
        }

        public void Work(int hours)
        {
            if (hours > currentPower)
            {
                hours = currentPower;
            }

            base.Work(hours);
            currentPower -= hours;
        }

        public override void Recharge()
        {
            currentPower = capacity;
        }

        public override void Sleep()
        {
            throw new InvalidOperationException("Robots cannot sleep");
        }
    }
}