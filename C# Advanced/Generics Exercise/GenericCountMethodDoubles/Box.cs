using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDoubles
{
    public class Box<T>where T:IComparable<T>
    {
        private List<T> list;
        public Box()
        {
            this.list = new List<T>();
        }
        public void Add(T element)
        {
            this.list.Add(element);
        }
        public int CompareElements(T element)
        {
            int counter = 0;
            for (int i = 0; i <this.list.Count ; i++)
            {
                T currentElement = list[i];
                if (currentElement.CompareTo(element)>0)
                {
                    counter++;
                }
            }
            return counter;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in this.list)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().Trim();
        }
    }
}
