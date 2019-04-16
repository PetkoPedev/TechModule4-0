using System;

namespace P02_SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            int num1 = number;

            do
            {
                sum += num1 % 10;
                num1 /= 10;
            }
            while (num1 >0);

            Console.WriteLine(sum);
        }
    }
}
