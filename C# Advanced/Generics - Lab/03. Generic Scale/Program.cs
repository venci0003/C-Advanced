using System;

namespace _03._Generic_Scale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EqualityScale<string> scale = new EqualityScale<string>("vesko", "vesko");

            Console.WriteLine(scale.AreEqual());
        }
    }
}
