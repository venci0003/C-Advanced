using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();
            string[,] matrix = CreateMatrix(matrixSize);

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                string[] tokens = command.Split(' ');

                if (isValidCommand(matrixSize, tokens))
                {
                    string tempValue = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])];
                    matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] = matrix[int.Parse(tokens[3]), int.Parse(tokens[4])];
                    matrix[int.Parse(tokens[3]), int.Parse(tokens[4])] = tempValue;
                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
        }

        private static void PrintMatrix(string[,] matrix)
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

        static string[,] CreateMatrix(int[] matrixSize)
        {
            string[,] matrix = new string[matrixSize[0], matrixSize[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colData = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colData[col];
                }
            }
            return matrix;
        }
        static bool isValidCommand(int[] matrixSize, string[] tokens)
        {
            bool isValidCommand =
                 tokens[0] == "swap" && tokens.Length == 5
                 && int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < matrixSize[0]
                 && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < matrixSize[1]
                 && int.Parse(tokens[3]) >= 0 && int.Parse(tokens[3]) < matrixSize[0]
                 && int.Parse(tokens[4]) >= 0 && int.Parse(tokens[4]) < matrixSize[1];
            return isValidCommand;
        }
    }
}
