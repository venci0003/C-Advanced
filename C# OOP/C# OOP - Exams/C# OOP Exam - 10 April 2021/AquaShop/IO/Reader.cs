namespace AquaShop.IO
{
    using System;

    using AquaShop.IO.Contracts;

    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}