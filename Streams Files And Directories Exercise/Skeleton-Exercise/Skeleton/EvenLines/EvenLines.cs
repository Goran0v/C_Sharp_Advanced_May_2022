namespace EvenLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static List<string> ProcessLines(string inputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            List<string> words = new List<string>();
            using (reader)
            {
                int num = 0;
                string input;
                while ((input = Console.ReadLine()) != null)
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (!char.IsLetterOrDigit(input[i]))
                        {
                            input.Replace(input[i], '@');
                        }
                    }
                    string text = input.Reverse().ToString();
                    if (num % 2 == 0)
                    {
                        words.Add(text);
                        words.Add(" ");
                    }
                    num++;
                }
            }
            return words;
        }
    }
}
