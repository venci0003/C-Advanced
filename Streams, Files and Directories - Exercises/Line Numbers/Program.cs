using System;
using System.IO;

public class LineNumbers
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\text.txt";
        string outputFilePath = @"..\..\..\output.txt";
        Zip
        ProcessLines(inputFilePath, outputFilePath);
    }
    public static void ProcessLines(string inputFilePath, string outputFilePath)
    {
        StreamWriter writer = new StreamWriter(outputFilePath);
        using (StreamReader reader = new StreamReader(inputFilePath))
        {
            int numberOfLine = 1;
            while (!reader.EndOfStream)
            {
                int countLetters = 0;
                int countSymbols = 0;
                string line = reader.ReadLine();
                foreach (char symbol in line)
                {
                    if (char.IsLetter(symbol))
                    {
                        countLetters++;
                    }
                    else
                    {
                        countSymbols++;
                    }
                }
                writer.WriteLine($"Line {numberOfLine}: {line} ({countLetters})({countSymbols})");
                numberOfLine++;
            }
            writer.Close();
        }
    }
}

