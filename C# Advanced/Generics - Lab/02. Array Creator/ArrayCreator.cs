using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Array_Creator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int arrayLength, T value)
        {
            T[] array = new T[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = value;
            }
            return array;
        }
    }
}
