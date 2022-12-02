using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type type = typeof(StartUp);
            foreach (MemberInfo method in type.GetMethods((BindingFlags)60))
            {
                object[] atributes = method.GetCustomAttributes(false);
                foreach (var item in atributes)
                {
                    AuthorAttribute author = item as AuthorAttribute;
                    if (author!=null)
                    {
                        Console.WriteLine($"{method.Name} is written by {author.Name}");
                    }
                }
            }
        }
    }
}
