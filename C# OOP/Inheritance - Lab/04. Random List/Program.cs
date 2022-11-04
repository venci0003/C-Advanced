using System;

namespace _04._Random_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomList randomList = new RandomList();
            randomList.Add("1");
            randomList.Add("2");
            randomList.Add("3");
            randomList.Add("4");
            randomList.Add("5");
            Console.WriteLine(string.Join(", ", randomList));
            Console.WriteLine();
            Console.WriteLine(randomList.RandomString());
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", randomList));
        }
    }
}
