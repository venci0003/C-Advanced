using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodString
{
    public class Box<T>
    {
        private T element;
        public Box(T element)
        {
            this.element = element;
        }
        public T Element { get { return this.element; } }
        public override string ToString()
        {
            return $"{typeof(T)}: {this.element}";
        }
    }
}
