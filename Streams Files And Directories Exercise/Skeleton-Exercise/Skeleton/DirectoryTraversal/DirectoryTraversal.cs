﻿namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
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
            string[] files = Directory.GetFiles(inputFolderPath);
            Dictionary<string, List<FileInfo>> extensionInfo = new Dictionary<string, List<FileInfo>>();
            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                string extension = fileInfo.Extension;

                if (!extensionInfo.ContainsKey(extension))
                {
                    extensionInfo.Add(extension, new List<FileInfo>());
                }
                extensionInfo[extension].Add(fileInfo);
            }

            StringBuilder text = new StringBuilder();
            foreach (var entry in extensionInfo.OrderByDescending(entry => entry.Value.Count).ThenBy(name => name.Key))
            {
                string extension = entry.Key;
                text.AppendLine(extension);
                List<FileInfo> filesInfo = entry.Value;
                filesInfo.OrderByDescending(file => file.Length);
                foreach (var fileInfo in filesInfo)
                {
                    text.AppendLine($"--{fileInfo.Name} - {fileInfo.Length / 1024:f3}kb");
                }
            }

            return text.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string pathReport = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(pathReport, textContent);
        }
    }
}
