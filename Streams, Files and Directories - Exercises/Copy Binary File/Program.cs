using System;
using System.IO;

namespace CopyBinaryFile
{
    using System;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            FileStream output = new FileStream(outputFilePath, FileMode.Create);
            using (FileStream reader = new FileStream(inputFilePath, FileMode.Open))
            {
                byte[] buffer = new byte[reader.Length];
                reader.Read(buffer, 0, buffer.Length);
                output.Write(buffer, 0, buffer.Length);
            }
            output.Close();
        }
    }
}
