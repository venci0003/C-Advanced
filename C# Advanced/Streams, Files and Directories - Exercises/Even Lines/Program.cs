using System;
using System.Linq;
using System.IO;
namespace EvenLines
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder stringBuilder = new StringBuilder();
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int row = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (row % 2 == 0)
                    {
                        line = line.Replace("-", "@");
                        line = line.Replace(",", "@");
                        line = line.Replace(".", "@");
                        line = line.Replace("!", "@");
                        line = line.Replace("?", "@");
                        string result = GetReverse(line);
                        stringBuilder.AppendLine(result);
                    }
                    row++;
                }
            }
            return stringBuilder.ToString();
        }

        static string GetReverse(string line)
        {
            List<string> list = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] array = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }
            for (int i = 0; i < array.Length / 2; i++)
            {
                string currentElement = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = currentElement;
            }
            string result = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i]+" ";
            }
            return result;
        }
    }
}
