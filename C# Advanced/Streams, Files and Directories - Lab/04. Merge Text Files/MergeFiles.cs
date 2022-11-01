namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            string line = string.Empty;
            using var writer = new StreamWriter(outputFilePath);
            using var firstReader = new StreamReader(firstInputFilePath);
            using var secondReader = new StreamReader(secondInputFilePath);

            while (line != null)
            {
                line = firstReader.ReadLine();
                if (line != null)
                    writer.WriteLine(line);                

                line = secondReader.ReadLine();
                if (line != null)
                    writer.WriteLine(line);                
            }
            writer.Close();
            firstReader.Close();
            secondReader.Close();
        }
    }
}
