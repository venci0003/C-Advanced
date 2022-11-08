namespace Collection_Hierarchy.IO.Models
{
    using IO.Contracts;
    using System;
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
