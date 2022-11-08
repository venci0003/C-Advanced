namespace Collection_Hierarchy.IO.Models
{
    using System;

    using Collection_Hierarchy.IO.Contracts;
    public class ConsoleWriter : IWriter
    {
        public void Write(object obj)
        {
           Console.Write(obj.ToString());
        }

        public void WriteLine(object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
