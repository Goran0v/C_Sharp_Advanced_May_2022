namespace ExtractBytes
{
    using System;
    using System.IO;
    public class ExtractBytes
    {
        static void Main(string[] args)
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            StreamReader reader = new StreamReader(bytesFilePath);
            int sum = 0;
            using (reader)
            {
                sum += int.Parse(reader.ReadLine());
            }
            byte[] buffer = new byte[sum];
            using FileStream fileReader = new FileStream("example.png", FileMode.Open, FileAccess.Read);
            using FileStream fileWriter = new FileStream("output.bin", FileMode.Create, FileAccess.Write);

            int bytes = fileReader.Read(buffer, 0, buffer.Length);
            fileWriter.Write(buffer, 0, bytes);
        }
    }
}
