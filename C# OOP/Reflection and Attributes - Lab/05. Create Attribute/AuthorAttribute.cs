using System;
using System.Diagnostics.CodeAnalysis;

namespace AuthorProblem
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AuthorAttribute : Attribute
    {
        private string name;
        public AuthorAttribute(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
    }
}