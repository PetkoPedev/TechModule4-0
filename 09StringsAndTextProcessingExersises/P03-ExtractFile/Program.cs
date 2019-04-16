using System;

namespace P03_ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int startIndexOfFile = path.LastIndexOf('\\') + 1;
            string file = path.Substring(startIndexOfFile);
            int startIndexOfExtension = file.LastIndexOf('.') + 1;
            string nameOfFile = file.Substring(0, startIndexOfExtension - 1);
            string extension = file.Substring(startIndexOfExtension);
            Console.WriteLine($"File name: {nameOfFile}");
            Console.WriteLine($"File extension: {extension}");
            
        }
    }
}
