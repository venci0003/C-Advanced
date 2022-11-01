
namespace ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string zipArchive = @"..\..\..\archive.zip";
            string extractedFileName = @"..\..\..\extracted.png";

            ZipFileToArchive(inputFilePath, zipArchive);

            string name=Path.GetFileName(inputFilePath);
            ExtractFileFromArchive(zipArchive,name , extractedFileName);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            using (ZipArchive zip = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create))
            {
                zip.CreateEntryFromFile(inputFilePath, "copyMe.png");
            }
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            using (ZipArchive zip = ZipFile.OpenRead(zipArchiveFilePath))
            {
                ZipArchiveEntry current = zip.GetEntry(fileName);
                current.ExtractToFile(outputFilePath);
            }
        }
    }
}

