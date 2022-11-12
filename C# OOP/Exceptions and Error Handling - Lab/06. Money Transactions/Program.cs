using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Money_Transactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> bankAccounts = new Dictionary<int, double>();
            string[] input = Console.ReadLine().Split(new char[] { ',', '-' });

            AddElements(bankAccounts, input);

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] tokens = command.Split();

                try
                {
                    if (tokens[0] != "Deposit" && tokens[0] != "Withdraw")
                    {
                        throw new InvalidOperationException("Invalid command!");
                    }
                    else
                    {
                        if (tokens[0] == "Deposit")
                        {
                            int account = int.Parse(tokens[1]);

                            double balance = double.Parse(tokens[2]);

                            if (!bankAccounts.ContainsKey(account))
                            {
                                throw new InvalidOperationException("Invalid account!");
                            }
                            else
                            {
                                bankAccounts[account] += balance;
                                Console.WriteLine($"Account {account} has new balance: {bankAccounts[account]:f2}");
                            }
                        }
                        else if (tokens[0] == "Withdraw")
                        {
                            int account = int.Parse(tokens[1]);

                            double withdrawValue = double.Parse(tokens[2]);

                            if (!bankAccounts.ContainsKey(account))
                            {
                                throw new InvalidOperationException("Invalid account!");
                            }
                            else
                            {
                                if (withdrawValue > bankAccounts[account])
                                {
                                    throw new InvalidOperationException("Insufficient balance!");
                                }
                                else
                                {
                                    bankAccounts[account] -= withdrawValue;
                                    Console.WriteLine($"Account {account} has new balance: {bankAccounts[account]:f2}");
                                }
                            }
                        }
                    }
                }
                catch (InvalidOperationException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
            }
        }

        private static void AddElements(Dictionary<int, double> bankAccounts, string[] input)
        {
            for (int i = 0; i < input.Length; i += 2)
            {
                int account = int.Parse(input[i]);

                double value = double.Parse(input[i + 1]);

                bankAccounts[account] = value;
            }
        }
    }
}
