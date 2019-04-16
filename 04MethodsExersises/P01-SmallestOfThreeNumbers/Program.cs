using System;

namespace P01_SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = GetSmallestOfThreeNumbers(a, b, c);
            Console.WriteLine(result);
        }

        static int GetSmallestOfThreeNumbers(int a, int b, int c)
        {
            int minNumber = Math.Min(Math.Min(a, b), c);
            return minNumber;
        }
    }
}
