using System;
using System.IO;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumRange = 0;
            string readedFile = string.Empty;
            int convertedIntFile;
            int answer = 0;

            string inputFilePath = $"Input.txt";
            string outputFilePath = $"Output.txt";

            Random rnd = new Random(DateTime.Now.Millisecond);
            sumRange = rnd.Next(-10000, 10000);

            if (File.Exists(inputFilePath))
                File.Delete(inputFilePath);
            if (File.Exists(outputFilePath))
                File.Delete(outputFilePath);

            using (FileStream fileStream = new FileStream(inputFilePath, FileMode.OpenOrCreate))
            {
                byte[] result = System.Text.Encoding.Default.GetBytes(sumRange.ToString());
                fileStream.Write(result, 0, result.Length);
            }

            WriteLine($"Sum range is '1' - '{sumRange:N0}'");

            using (FileStream fileStream = File.OpenRead(inputFilePath))
            {
                byte[] array = new byte[fileStream.Length];
                fileStream.Read(array, 0, array.Length);
                readedFile = System.Text.Encoding.Default.GetString(array);
                convertedIntFile = Convert.ToInt32(readedFile);
            }

            if (convertedIntFile > 0)
                answer = (1 + convertedIntFile) * convertedIntFile / 2;
            else
                answer = (-1 + convertedIntFile) * convertedIntFile / 2;

            WriteLine($"Sum is: '{answer:N0}'");

            using (FileStream fileStream = new FileStream(outputFilePath, FileMode.OpenOrCreate))
            {
                byte[] result = System.Text.Encoding.Default.GetBytes(answer.ToString());
                fileStream.Write(result, 0, result.Length);
            }
        }
    }
}