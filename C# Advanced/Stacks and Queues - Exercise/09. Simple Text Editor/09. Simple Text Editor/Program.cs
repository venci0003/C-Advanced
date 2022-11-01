using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            StringBuilder stringToBeManipulated = new StringBuilder();
            Stack<string> memory = new Stack<string>();
            memory.Push(string.Empty);
            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command[0] == "1")
                {
                    string wordToBeAppended = command[1];
                    stringToBeManipulated.Append(wordToBeAppended);
                    memory.Push(stringToBeManipulated.ToString());
                }
                else if (command[0] == "2")
                {
                    int charactersToRemove = int.Parse(command[1]);
                    stringToBeManipulated = stringToBeManipulated.Remove(stringToBeManipulated.Length - charactersToRemove, charactersToRemove);
                    memory.Push(stringToBeManipulated.ToString());
                }
                else if (command[0] == "3")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index <= stringToBeManipulated.Length)
                    {
                        Console.WriteLine(stringToBeManipulated[index - 1]);
                    }
                }
                else if (command[0] == "4")
                {
                    memory.Pop();
                    string previousVersion = memory.Peek();
                    stringToBeManipulated = new StringBuilder(previousVersion);
                }
            }
        }
    }
}
