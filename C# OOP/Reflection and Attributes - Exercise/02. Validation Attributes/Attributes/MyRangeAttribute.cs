using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Attributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;
        private int maxValue;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }
        public int MinValue
        {
            get => minValue;
            private set => minValue = value;
        }

        public int MaxValue
        {
            get => maxValue;
            private set => maxValue = value;
        }
        public override bool IsValid(object obj)
        {
            int num = (int)obj;
            if (num >= MinValue && num <= MaxValue)
            {
                return true;
            }
            return false;
        }
    }
}
