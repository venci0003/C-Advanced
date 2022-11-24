using System.Collections.Generic;
using System.Linq;
using CommandPattern.Core;
using CommandPattern.Core.Contracts;
using CommandPattern.Core.Models;

namespace CommandPattern
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICommandInterpreter command = new CommandInterpreter();
            IEngine engine = new Engine(command);
            engine.Run();
           
        }
    }
}