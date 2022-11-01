using System;

namespace GenericBoxofInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            for (int i = 0; i < loops; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(input);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
