using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<decimal,string> addVAT = n => (n * 1.2M).ToString("F2");

            Console.WriteLine(string.Join("\n",
                Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(n => decimal.Parse(n))
                 .Select(addVAT)));
        }
    }
}
