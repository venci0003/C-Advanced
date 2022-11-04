using System.Collections.Generic;

namespace _05._Stack_of_Strings
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            if (Count <= 0)
            {
                return true;
            }
            return false;
        }

        public Stack<string> AddRange()
        {
            return this;
        }
    }
}
