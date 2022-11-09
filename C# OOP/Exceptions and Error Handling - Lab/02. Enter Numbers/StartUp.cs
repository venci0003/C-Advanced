using System;

namespace _02._Enter_Numbers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int start = 1;
            int end = 100;
            int index = 0;
            int minStart = start;
            while (index < array.Length)
            {
                try
                {
                    ReadNumbers(start, end, array, ref index, ref minStart);
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            Console.WriteLine(string.Join(", ", array));
        }

        static void ReadNumbers(int start, int end, int[] array, ref int index, ref int minStart)
        {
            string input = Console.ReadLine();

            int number = 0;
            bool isNumber = int.TryParse(input, out number);
            if (!isNumber)
            {
                throw new FormatException("Invalid Number!");
            }
            if (number > minStart && number < end)
            {
                array[index++] = number;
                minStart = number;
            }
            else
            {
                throw new ArgumentException($"Your number is not in range {minStart} - 100!");
            }
        }
    }
}