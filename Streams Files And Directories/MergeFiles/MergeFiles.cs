namespace MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class MergeFiles
    {
        static void Main(string[] args)
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            StreamReader first = new StreamReader(firstInputFilePath);
            StreamReader second = new StreamReader(secondInputFilePath);
            int num1 = 0;
            int num2 = 0;
            using (first)
            {
                string line;
                while ((line = Console.ReadLine()) != null)
                {
                    num1++;
                }
            }
            using (second)
            {
                string line;
                while ((line = Console.ReadLine()) != null)
                {
                    num2++;
                }
            }

            if (num1 > num2)
            {
                using (first)
                {
                    StreamWriter writer = new StreamWriter(outputFilePath);
                    string line1;
                    using (second)
                    {
                        string line2;
                        while ((line2 = Console.ReadLine()) != null)
                        {
                            line1 = Console.ReadLine();
                            writer.WriteLine(line1);
                            writer.WriteLine(line2);
                        }
                        while ((line1 = Console.ReadLine()) != null)
                        {
                            writer.WriteLine(line1);
                        }
                    }
                }
            }
            else
            {
                using (second)
                {
                    StreamWriter writer = new StreamWriter(outputFilePath);
                    string line2;
                    using (first)
                    {
                        string line1;
                        while ((line1 = Console.ReadLine()) != null)
                        {
                            line2 = Console.ReadLine();
                            writer.WriteLine(line2);
                            writer.WriteLine(line1);
                        }
                        while ((line2 = Console.ReadLine()) != null)
                        {
                            writer.WriteLine(line2);
                        }
                    }
                }
            }
        }
    }
}
