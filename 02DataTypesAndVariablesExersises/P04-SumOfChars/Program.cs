using System;

namespace P04_SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            while (n > 0)
            {
                char character = char.Parse(Console.ReadLine());
                sum += (int)character;
                n--;
            }
            Console.WriteLine($"The sum equals: {sum}");
            
        }
    }
}
