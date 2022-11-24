using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Core.Models
{
    public class ExitCommand : ICommand
    {
        private const int SuccessExitCode = 0;
        public string Execute(string[] args)
        {
           Environment.Exit(SuccessExitCode);
            return null;
        }
    }
}
