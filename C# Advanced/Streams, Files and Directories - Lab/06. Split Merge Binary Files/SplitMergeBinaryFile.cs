namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (var fileSource = new FileStream(sourceFilePath, FileMode.Open))
            {
                byte[] firstBuffer = new byte[(fileSource.Length + 1) / 2];
                fileSource.Read(firstBuffer, 0, firstBuffer.Length);
                using (var fileTarget1 = new FileStream(partOneFilePath, FileMode.Create))
                {
                    fileTarget1.Write(firstBuffer, 0, firstBuffer.Length);
                }

                byte[] secondBuffer = new byte[fileSource.Length / 2];
                fileSource.Read(secondBuffer, 0, secondBuffer.Length);
                using (var fileTarget2 = new FileStream(partTwoFilePath, FileMode.Create))
                {
                    fileTarget2.Write(secondBuffer, 0, secondBuffer.Length);
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (var joinedFile = new FileStream(joinedFilePath, FileMode.Create))
            {
                byte[] firstBuffer = null;
                using (var firstFile = new FileStream(partOneFilePath, FileMode.Open))
                {
                    firstBuffer = new byte[firstFile.Length];
                    joinedFile.Write(firstBuffer);                    
                }
                byte[] secondBuffer = null;
                using (var secondFile = new FileStream(partTwoFilePath, FileMode.Open))
                {
                    secondBuffer = new byte[secondFile.Length];
                    joinedFile.Write(secondBuffer, 0, secondBuffer.Length);
                }
            }
        }
    }
}