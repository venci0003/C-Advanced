using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jaggedArraySize = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[jaggedArraySize][];

            for (int row = 0; row < jaggedArraySize; row++)
            {
                double[] colsData = Console.ReadLine().Split().Select(double.Parse).ToArray();

                jaggedArray[row] = colsData;
            }

            for (int row = 0; row < jaggedArraySize - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }
                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] /= 2;
                    }
                }
            }
            while (true)
            {
                string[] text = Console.ReadLine().Split();
                if (text[0] == "End")
                {
                    break;
                }
                string command = text[0];
                int row = int.Parse(text[1]);
                int col = int.Parse(text[2]);
                int value = int.Parse(text[3]);
                if (IndexIsValid(row, jaggedArray) && IndexIsValid(col, jaggedArray))
                {
                    if (command == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else if (command == "Subtract")
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
            }

            for (int row = 0; row < jaggedArraySize; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length ; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }
                Console.WriteLine();
            }
        }
        static bool IndexIsValid(int index, double[][] jaggedArray)
        => index < jaggedArray.Length && index >= 0;
    }
}

