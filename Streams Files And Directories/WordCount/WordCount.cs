namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main(string[] args)
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            StreamReader wordsToLookFor = new StreamReader(wordsFilePath);
            List<string> list = wordsToLookFor.ToString().Split(' ').ToList();
            Dictionary<string, int> words = new Dictionary<string, int>();
            for (int i = 0; i < list.Count; i++)
            {
                words.Add(list[i], 0);
            }
            StreamReader text = new StreamReader(textFilePath);
            using (text)
            {
                StreamWriter writer = new StreamWriter(outputFilePath);
                using (writer)
                {
                    string line;
                    while ((line = Console.ReadLine()) != null)
                    {
                        line = line.ToLower();
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (line[i] == ',' || line[i] == '.' || line[i] == '!' || line[i] == '?' || line[i] == '-')
                            {
                                line.Remove(i, 1);
                            }
                        }
                        string[] arr = line.Split(' ').ToArray();
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (words.ContainsKey(arr[i]))
                            {
                                words[arr[i]]++;
                            }
                        }

                        foreach (var word in words)
                        {
                            writer.WriteLine($"{word.Key} - {word.Value}");
                        }
                    }
                }
            }
        }
    }
}
