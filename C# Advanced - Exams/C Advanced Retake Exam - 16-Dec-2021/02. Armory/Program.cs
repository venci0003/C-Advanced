using System;

namespace _02._Armory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            int knightRow = 0;

            int knightCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] colsData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colsData[col];

                    if (matrix[row, col] == 'A')
                    {
                        knightRow = row;
                        knightCol = col;
                    }
                }

            }

            int moneySum = 0;

            while (true)
            {
                string command = Console.ReadLine();

                int currentRow = 0;

                int currentCol = 0;

                if (moneySum >= 65)
                {
                    Console.WriteLine("Very nice swords, I will come back for more!");
                    break;
                }
                else if (command == "up")
                {
                    currentRow = -1;

                }
                else if (command == "down")
                {
                    currentRow = 1;
                }
                else if (command == "left")
                {
                    currentCol = -1;
                }
                else if (command == "right")
                {
                    currentCol = 1;
                }

                if (isValid(knightRow + currentRow, knightCol + currentCol, matrix))
                {
                    matrix[knightRow, knightCol] = '-';

                    knightRow += currentRow;
                    knightCol += currentCol;
                }
                else
                {
                    matrix[knightRow, knightCol] = '-';
                    Console.WriteLine("I do not need more swords!");
                    break;
                }

                if (char.IsDigit(matrix[knightRow, knightCol]))
                {
                    moneySum += (int)matrix[knightRow, knightCol] - 48;

                    matrix[knightRow, knightCol] = 'A';
                }
                else if (matrix[knightRow, knightCol] == 'M')
                {
                    matrix[knightRow, knightCol] = '-';

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {

                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {

                            if (matrix[row, col] == 'M')
                            {
                                knightRow = row;
                                knightCol = col;
                            }
                        }
                    }

                    matrix[knightRow, knightCol] = 'A';
                }
                else
                {
                    matrix[knightRow, knightCol] = 'A';
                }
            }

            Console.WriteLine($"The king paid {moneySum} gold coins.");
            PrintMatrix(matrix);
        }

        static bool isValid(int row, int col, char[,] matrix)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }
        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}

