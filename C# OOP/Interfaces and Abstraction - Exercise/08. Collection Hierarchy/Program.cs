namespace Collection_Hierarchy
{
    using Collection_Hierarchy.Cores;
    using Collection_Hierarchy.IO.Contracts;
    using Collection_Hierarchy.IO.Models;
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();

            IWriter writer = new ConsoleWriter();

            Engine engine = new Engine();

            engine.Run(reader, writer);

        }
    }
}
