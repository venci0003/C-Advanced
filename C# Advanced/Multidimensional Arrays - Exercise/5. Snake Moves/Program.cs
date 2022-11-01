using System;
using System.Linq;

namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();

            string word = Console.ReadLine();

            char[,] matrix = new char[dimensions[0], dimensions[1]];

            int currentWordIndex = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (currentWordIndex == word.Length)
                        {
                            currentWordIndex = 0;
                        }
                        matrix[row, col] = word[currentWordIndex];
                        
                        currentWordIndex++;
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        if (currentWordIndex == word.Length)
                        {
                            currentWordIndex = 0;
                        }
                        matrix[row, col] = word[currentWordIndex];

                        currentWordIndex++;
                    }
                }
            }

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
