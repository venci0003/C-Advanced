

namespace DirectoryTraversal
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] files = Directory.GetFiles(inputFolderPath, "*");
            Dictionary<string, Dictionary<string, double>> dictionary = new Dictionary<string, Dictionary<string, double>>();
            foreach (var file in files)
            {
                string filaName = Path.GetFileName(file);
                string extension = Path.GetExtension(file);
                double size = new FileInfo(file).Length / 1024.0;
                if (!dictionary.ContainsKey(extension))
                {
                    dictionary[extension] = new Dictionary<string, double>();
                }
                dictionary[extension][filaName] = size;
            }
            foreach (var item in dictionary.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                stringBuilder.AppendLine($"{item.Key}");
                foreach (KeyValuePair<string, double> file in item.Value.OrderByDescending(x => x.Value))
                {
                    stringBuilder.AppendLine($"--{file.Key}{item.Key} - {file.Value:F3}kb");
                }
            }
            return stringBuilder.ToString().Trim();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string dekstopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(dekstopPath, textContent);
        }
    }
}

