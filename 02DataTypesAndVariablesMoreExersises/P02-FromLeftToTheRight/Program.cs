using System;
using System.Linq;

namespace P02_FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();

                long sum = 0;
                if (input[0] > input[1])
                {
                    long num1 = input[0];
                    while (num1 != 0)
                    {
                        sum += num1 % 10;
                        num1 /= 10;
                    }
                    
                }
                else
                {
                    long num1 = input[1];
                    while (num1 != 0)
                    {
                        sum += num1 % 10;
                        num1 /= 10;
                    }
                }
                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}
