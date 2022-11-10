using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _05._Play_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intInput = Console.ReadLine().Split().Select(int.Parse).ToList();

            int numberOfExceptions = 0;
            while (true)
            {
                if (numberOfExceptions == 3)
                {
                    break;
                }
                string command = Console.ReadLine();

                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (tokens[0] == "Show")
                    {
                        int index = 0;

                        bool isNumber = int.TryParse(tokens[1], out index);

                        if (!isNumber)
                        {
                            throw new FormatException("The variable is not in the correct format!");
                        }
                        else if (index < 0 || index >= intInput.Count)
                        {
                            throw new InvalidOperationException("The index does not exist!");
                        }

                        Console.WriteLine(intInput[index]);
                    }
                    else if (tokens[0] == "Print")
                    {
                        int startIndex = 0;

                        int endIndex = 0;

                        bool StartIndexIsNumber = int.TryParse(tokens[1], out startIndex);

                        bool EndIndexIsNumber = int.TryParse(tokens[2], out endIndex);

                        if (!StartIndexIsNumber || !EndIndexIsNumber)
                        {
                            throw new FormatException("The variable is not in the correct format!");
                        }
                        else if (startIndex < 0 || startIndex >= intInput.Count || endIndex < 0 || endIndex >= intInput.Count)
                        {
                            throw new InvalidOperationException("The index does not exist!");
                        }

                        List<int> list = new List<int>();

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            list.Add(intInput[i]);
                        }

                        Console.WriteLine(String.Join(", ", list));
                    }
                    else if (tokens[0] == "Replace")
                    {
                        int index = 0;

                        int element = 0;

                        bool indexIsNumber = int.TryParse(tokens[1], out index);

                        bool elementIsNumber = int.TryParse(tokens[2], out element);

                        if (!indexIsNumber || !elementIsNumber)
                        {
                            throw new FormatException("The variable is not in the correct format!");
                        }
                        else if (index < 0 || index >= intInput.Count)
                        {
                            throw new InvalidOperationException("The index does not exist!");
                        }

                        intInput[index] = element;
                    }
                }
                catch (FormatException exception)
                {

                    Console.WriteLine(exception.Message);
                    numberOfExceptions++;
                }
                catch (InvalidOperationException exception)
                {
                    Console.WriteLine(exception.Message);
                    numberOfExceptions++;
                }

            }
            Console.WriteLine(string.Join(", ", intInput));
        }
    }
}
