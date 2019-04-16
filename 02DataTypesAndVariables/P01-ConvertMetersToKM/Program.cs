using System;

namespace P01_ConvertMetersToKM
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine())/ 1000;
            Console.WriteLine($"{meters:F2}");
        }
    }
}
