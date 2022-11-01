using System;
using System.Linq;
using System.Collections.Generic;
namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int rows = matrixSize;
            int columns = matrixSize;
            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                int[] rowsData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = rowsData[col];
                }
            }
            int sum = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine(sum);
        }
    }
}
