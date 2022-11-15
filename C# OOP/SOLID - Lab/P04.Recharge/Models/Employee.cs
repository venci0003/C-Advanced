namespace P04.Recharge.Models
{
    using System;
    using P04.Recharge.Models.Contracts;

    public class Employee : Worker, ISleeper
    {
        public Employee(string id) : base(id)
        {
        }

        public override void Sleep()
        {
            // sleep...
        }

        public override void Recharge()
        {
            throw new InvalidOperationException("Employees cannot recharge");
        }

    }
}
