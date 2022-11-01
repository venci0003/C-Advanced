using System;

namespace GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int loops = int.Parse(Console.ReadLine());
            for (int i = 0; i < loops; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }
            string inputToCompare = Console.ReadLine();
            Console.WriteLine(box.CompareElements(inputToCompare));
        }
    }
}
