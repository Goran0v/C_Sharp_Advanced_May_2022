namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            using (reader)
            {
                StreamWriter writer = new StreamWriter(outputFilePath);
                int lineCounter = 1;
                int punctCounter = 0;
                int letterCounter = 0;
                string input;
                while ((input = Console.ReadLine()) != null)
                {
                    string clearLine = input;
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (char.IsLetter(input[i]))
                        {
                            letterCounter++;
                        }
                        else if (!char.IsLetterOrDigit(input[i]))
                        {
                            punctCounter++;
                        }
                    }
                    writer.WriteLine($"Line {lineCounter}: {clearLine} ({letterCounter})({punctCounter})");
                    lineCounter++;
                    punctCounter = 0;
                    letterCounter = 0;
                }
            }
        }
    }
}
