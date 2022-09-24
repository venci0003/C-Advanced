using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regularGuests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "PARTY")
                {
                    break;
                }
                if (command.Length == 8)
                {
                    for (int i = 0; i < command.Length; i++)
                    {
                        char currentCharacter = command[i];
                        if (char.IsDigit(currentCharacter))
                        {
                            vipGuests.Add(command);
                            break;
                        }
                        else
                        {
                            regularGuests.Add(command);
                            break;
                        }
                    }
                }
            }
            
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                vipGuests.Remove(command);
                regularGuests.Remove(command);
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);

            if (vipGuests.Count > 0)
            {
                Console.WriteLine(String.Join("\n", vipGuests));
            }

            if (regularGuests.Count > 0)
            {
                Console.WriteLine(String.Join("\n", regularGuests));
            }
        }
    }
}
