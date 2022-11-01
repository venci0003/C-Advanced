using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] charactersToBeAddedToMatrix = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(n => char.Parse(n)).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = charactersToBeAddedToMatrix[col];
                }
            }

            int countOfEqualCells = 0;
            if (matrix.GetLength(0) > 1 && matrix.GetLength(1) > 1) 
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        if (matrix[row,col] == matrix[row,col + 1] && matrix[row, col] == matrix[row + 1, col + 1] && matrix[row,col] == matrix[row + 1,col])
                        {
                               countOfEqualCells++;
                        }
                    }
                }
                Console.WriteLine(countOfEqualCells);
            }
        }
    }
}
