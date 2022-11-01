using System;
using System.Security.Cryptography;

namespace _02._Wall_Destroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            int characterRow = 0;

            int characterCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                char[] colsInput = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colsInput[col];

                    if (matrix[row, col] == 'V')
                    {
                        characterRow = row;

                        characterCol = col;
                    }
                }
            }

            int wallsDestroyed = 1;

            int rodsHit = 0;

            int currentDestroyedWalls = 0;

            while (true)
            {
                int currentRow = 0;

                int currentCol = 0;

                int previousRow = 0;

                int previousCol = 0;

                string input = Console.ReadLine();

                if (input == "End")
                {

                    Console.WriteLine($"Vanko managed to make {wallsDestroyed} hole(s) and he hit only {rodsHit} rod(s).");
                    PrintMatrix(matrix);
                    break;
                }
                else if (input == "up")
                {
                    currentRow = -1;
                }
                else if (input == "down")
                {
                    currentRow = 1;
                }
                else if (input == "left")
                {
                    currentCol = -1;
                }
                else if (input == "right")
                {
                    currentCol = 1;
                }

                if (isValid(currentCol + characterCol, currentRow + characterRow, matrix))
                {
                    matrix[characterRow, characterCol] = '*';

                    previousRow = characterRow;
                    previousCol = characterCol;

                    characterRow += currentRow;
                    characterCol += currentCol;

                    if (matrix[characterRow, characterCol] == 'R')
                    {

                        Console.WriteLine("Vanko hit a rod!");
                        matrix[characterRow, characterCol] = 'R';

                        characterRow = previousRow;
                        characterCol = previousCol;

                        matrix[characterRow, characterCol] = 'V';

                        rodsHit++;
                        continue;
                    }
                    else if (matrix[characterRow, characterCol] == 'C')
                    {
                        wallsDestroyed++;

                        matrix[characterRow, characterCol] = 'E';

                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {wallsDestroyed} hole(s).");
                        PrintMatrix(matrix);
                        return;
                    }
                    else if (matrix[characterRow, characterCol] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{characterRow}, {characterCol}]!");

                        matrix[characterRow, characterCol] = 'V';

                        continue;
                    }
                    else
                    {
                        matrix[characterRow, characterCol] = 'V';
                    }
                    wallsDestroyed++;
                }
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
