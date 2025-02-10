﻿namespace CopyDirectory
{
    using System;
    using System.IO;
    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath =  @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            Directory.CreateDirectory(outputPath);
            var files = Directory.GetFiles(inputPath);
            foreach (var file in files)
            {
                string fileName = Path.GetFileName(file);
                var copyDestination = Path.Combine(outputPath, fileName);
                File.Copy(fileName, outputPath);
                //Directory.Move(file, outputPath);
            }
        }
    }
}
