namespace ChristmasPastryShop.IO
{
    using System;
    using ChristmasPastryShop.IO.Contracts;

    public class Writer : IWriter
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
