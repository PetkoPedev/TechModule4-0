using System;

namespace P12_EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            while (true)
            {
                if (num % 2 == 0)
                {
                    break;
                }
                Console.WriteLine("Please write an even number.");
                num = Math.Abs(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"The number is: {num}");
        }
    }
}
