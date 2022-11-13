namespace Vehicles.IO
{
    using System;
    using Vehicles.IO.Interfaces;
    public class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();

    }
}
