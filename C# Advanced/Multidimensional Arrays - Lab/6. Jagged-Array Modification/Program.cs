using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                int[] colsData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = colsData[col];
                }
            }

            while (true)
            {
                string[] text = Console.ReadLine().Split();
                if (text[0] == "END")
                {
                    break;
                }
                string command = text[0];
                int rowIndex = int.Parse(text[1]);
                int columnIndex = int.Parse(text[2]);
                int value = int.Parse(text[3]);
                if (IndexIsValid(rowIndex,matrixSize) && IndexIsValid(columnIndex,matrixSize))
                {
                    if (command == "Add")
                    {
                        matrix[rowIndex, columnIndex] += value;
                    }
                    else if (command == "Subtract")
                    {
                        matrix[rowIndex, columnIndex] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
        static bool IndexIsValid(int index, int size)
        => index < size && index >= 0;
    }
}
