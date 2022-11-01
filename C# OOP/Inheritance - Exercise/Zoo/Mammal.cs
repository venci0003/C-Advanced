using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Mammal : Animal
    {
        public Mammal(string name) : base(name)
        {
        }

        public override string Name { get => base.Name; set => base.Name = value; }
    }
}
