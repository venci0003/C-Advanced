using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<T, Z>
    {
        public T FirstValue { get; set; }

        public Z SecondValue { get; set; }

        public override string ToString()
        {
            return $"{this.FirstValue} -> {this.SecondValue}";
        }
    }
}
