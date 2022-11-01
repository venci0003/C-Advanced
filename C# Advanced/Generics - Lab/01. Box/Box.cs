using System;
using System.Collections.Generic;

namespace _01._Box
{
    public class Box<T>
    {
        private List<T> list;
        public Box()
        {
            this.list = new List<T>();
        }
        public void Add(T element)
        {
            this.list.Insert(0,element);
        }
        public T Remove()
        {
            T elementToRemove = this.list[0];

            this.list.RemoveAt(0);

            return elementToRemove;
        }
        public int Count { get {return this.list.Count; } }
    }
}
