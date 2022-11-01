using System;
using System.Drawing;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = CreateMatrix(matrixSize);


            int firstSum = 0;
            int secondSum = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                firstSum += matrix[i, i];
                secondSum += matrix[i, matrixSize - i - 1];
            }
            Console.WriteLine($"{Math.Abs(firstSum - secondSum)}");
        }

        private static int[,] CreateMatrix(int matrixSize)
        {
            int[,] matrix = new int[matrixSize, matrixSize];
            for (int row = 0; row < matrixSize; row++)
            {
                int[] colData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = colData[col];
                }
            }
            return matrix;
        }
    }
}
