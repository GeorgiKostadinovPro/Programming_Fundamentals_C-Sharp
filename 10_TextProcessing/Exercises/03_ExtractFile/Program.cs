using System;

namespace _03_ExtractFile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] fileExtension = Console.ReadLine()
                .Split('\\', StringSplitOptions.RemoveEmptyEntries);

            string[] fileData = fileExtension[fileExtension.Length - 1]
                .Split('.', StringSplitOptions.RemoveEmptyEntries);

            string fileName = fileData[0];
            string extension = fileData[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}