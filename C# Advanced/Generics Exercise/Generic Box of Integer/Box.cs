using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxofInteger
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
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{typeof(T)}: {this.element}");

            return result.ToString().Trim();
        }
    }
}
