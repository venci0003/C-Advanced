using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Bear : Mammal
    {
        public Bear(string name) : base(name)
        {

        }
        public override string Name { get => base.Name; set => base.Name = value; }
    }
}
