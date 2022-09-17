using System;
using System.Collections.Generic;

namespace _1._Reverse_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            Stack<char> reversedMessage = new Stack<char>();

            foreach (var character in message)
            {
                reversedMessage.Push(character);
            }

            while (reversedMessage.Count > 0)
            {
                Console.Write(reversedMessage.Pop());
            }
        }
    }
}
