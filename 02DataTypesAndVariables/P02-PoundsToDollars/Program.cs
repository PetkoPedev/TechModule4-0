using System;

namespace P02_PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine()) * 1.31;
            Console.WriteLine($"{pounds:F3}");
        }
    }
}
