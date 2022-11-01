using System;
using System.IO;

namespace CopyDirectory
{
    using System;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = Console.ReadLine();
            string outputPath = Console.ReadLine();

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            Directory.CreateDirectory(outputPath);
            string[] files = Directory.GetFiles(inputPath, "*");
            foreach (string file in files)
            {
                string fullFilePath = outputPath + "\\" + Path.GetFileName(file);
                if (File.Exists(fullFilePath))
                {
                    continue;
                }
                File.Copy(file, fullFilePath);
            }
        }
    }
}
