namespace ChristmasPastryShop.IO
{
    using System;
    using ChristmasPastryShop.IO.Contracts;

    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
