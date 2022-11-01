using System;

namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triangleSize = int.Parse(Console.ReadLine());

            long[][] pascal = new long[triangleSize][];

            for (int row = 0; row < triangleSize; row++)
            {
                pascal[row] = new long[row + 1];
                for (int col = 0; col < pascal[row].Length; col++)
                {
                    if (row == 0)
                    {
                        pascal[row][col] = 1;
                        continue;
                    }
                    long currentValue = 0;
                    if (col > 0)
                    {
                        currentValue += pascal[row - 1][col - 1];
                    }
                    if (pascal[row].Length - 1 > col)
                    {
                        currentValue += pascal[row - 1][col];
                    }
                    pascal[row][col] = currentValue;
                }
            }
            for (int row = 0; row < pascal.Length; row++)
            {
                for (int col = 0; col < pascal[row].Length; col++)
                {
                    Console.Write($"{pascal[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
