using System;
using System.Linq;
using System.Collections.Generic;
namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int cols = matrixSize;
            int rows = matrixSize;

            int[,] matrix = new int[cols, rows];

            for (int row = 0; row < rows; row++)
            {
                string rowsData = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowsData[col];
                }
            }
            char targetSymbol = char.Parse(Console.ReadLine());
            for (int row = 0; row < rows; row++)
            {           
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row,col] == targetSymbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{targetSymbol} does not occur in the matrix");
        }
    }
}
