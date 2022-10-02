namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            DirectoryInfo folderInfo = new DirectoryInfo(folderPath);
            FileInfo[] files = folderInfo.GetFiles("*", SearchOption.AllDirectories);
            decimal sum = 0;
            foreach (FileInfo file in files)
            {
                sum += file.Length;
            }
            using (var writer = new StreamWriter(outputFilePath))
            {
                writer.Write(sum / 1024);
            }
        }
    }
}
