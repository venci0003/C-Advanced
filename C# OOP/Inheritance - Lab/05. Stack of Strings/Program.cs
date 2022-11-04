using System;

namespace _05._Stack_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackOfStrings strings = new StackOfStrings();
            Console.WriteLine(strings.IsEmpty());
            strings.Push("a");
            Console.WriteLine(strings.IsEmpty());
            strings.Pop();
            Console.WriteLine(strings.IsEmpty());
        }
    }
}
