
using System;
using System.Linq;
using System.Reflection;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Models
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] commandTokens = args.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string action = commandTokens[0];
            string[] commandArguments = commandTokens.Skip(1).ToArray();
            Assembly projects = Assembly.GetCallingAssembly();
            Type actionType = projects.GetTypes().FirstOrDefault(t=>t.Name==$"{action}Command" && t.GetInterfaces().Any(i=>i==typeof(ICommand)));
            Object actionInstance = Activator.CreateInstance(actionType);
            MethodInfo methodToExecute = actionType.GetMethods().FirstOrDefault(m => m.Name == "Execute");
            string result =(string) methodToExecute.Invoke(actionInstance, new object[] { commandArguments });
            return result;
        }
    }
}
