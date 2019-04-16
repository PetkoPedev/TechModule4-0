using System;

namespace P01_SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int maxNumber = Math.Max(Math.Max(a, b), c);
            int minNumber = Math.Min(Math.Min(a, b), c);
            int middleNumber = (a + b + c) - (maxNumber + minNumber);

            Console.WriteLine(maxNumber);
            Console.WriteLine(middleNumber);
            Console.WriteLine(minNumber);
        }
    }
}
