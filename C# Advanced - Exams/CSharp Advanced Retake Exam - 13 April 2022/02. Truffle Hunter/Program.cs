using System;
using System.Linq;

namespace _02._Truffle_Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = ReadMatrixInformation();

            int blackTruffleCount = 0;

            int summerTruffleCount = 0;

            int whiteTruffleCount = 0;

            int trufflesEatenByTheBoar = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Stop the hunt")
                {
                    break;
                }

                string[] token = command.Split();

                if (token[0] == "Collect")
                {
                    int row = int.Parse(token[1]);

                    int col = int.Parse(token[2]);

                    if (isValid(row, col, matrix))
                    {
                        if (matrix[row, col] == 'B')
                        {
                            matrix[row, col] = '-';
                            blackTruffleCount++;
                        }
                        else if (matrix[row, col] == 'S')
                        {
                            matrix[row, col] = '-';
                            summerTruffleCount++;
                        }
                        else if (matrix[row, col] == 'W')
                        {
                            matrix[row, col] = '-';
                            whiteTruffleCount++;
                        }
                    }
                }
                else if (token[0] == "Wild_Boar")
                {

                    int rowIndex = int.Parse(command.Split().Skip(1).First());

                    int colIndex = int.Parse(command.Split().Skip(2).First());

                    string direction = command.Split().Last();

                    while (isValid(rowIndex, colIndex, matrix))
                    {
                        if ((new char[] { 'B', 'S', 'W' }).Contains(matrix[rowIndex, colIndex]))
                        {
                            trufflesEatenByTheBoar++;
                            matrix[rowIndex, colIndex] = '-';
                        }
                        switch (direction)
                        {
                            case "up": rowIndex -= 2; break;
                            case "down": rowIndex += 2; break;
                            case "left": colIndex -= 2; break;
                            case "right": colIndex += 2; break;
                        }
                    }
                }
            }

            Console.WriteLine($"Peter manages to harvest {blackTruffleCount} black, {summerTruffleCount} summer, and {whiteTruffleCount} white truffles.");

            Console.WriteLine($"The wild boar has eaten {trufflesEatenByTheBoar} truffles.");

            PrintMatrix(matrix);
        }
        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
        static bool isValid(int row, int col, char[,] matrix)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }

        static char[,] ReadMatrixInformation()
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                char[] colsInput = string.Join("", Console.ReadLine().Split()).ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = colsInput[col];
                }
            }
            return matrix;
        }
    }
}
