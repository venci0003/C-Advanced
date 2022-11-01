using System;
using System.Collections.Generic;
namespace _01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueUsernames = new HashSet<string>();

            int countOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfInputs; i++)
            {
                string username = Console.ReadLine();

                uniqueUsernames.Add(username);
            }

            Console.WriteLine(string.Join("\n",uniqueUsernames));
        }
    }
}
