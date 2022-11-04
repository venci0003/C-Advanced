using System;
using System.Collections.Generic;

namespace _04._Random_List
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random random = new Random();

            int indexToRemove = random.Next(0, Count);
            string element = this[indexToRemove];
            RemoveAt(indexToRemove);
            return element;
        }
    }
}
