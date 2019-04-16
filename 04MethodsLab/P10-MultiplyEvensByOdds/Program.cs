using System;

namespace P10_MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int multipleOfEvenAndOdds = GetSumOfEvenAndOdds(number);
            Console.WriteLine(multipleOfEvenAndOdds);
        }

        private static int GetSumOfEvenAndOdds(int number)
        {
            int even = GetSumOfEvenDigits(number);
            int odd = GetSumOfOddDigits(number);
            int result = even * odd;
            return result;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                number /= 10;
                if (remainder % 2 == 1)
                {
                    sum += remainder;
                }
            }
            return sum;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                number /= 10;
                if (remainder % 2 == 0)
                {
                    sum += remainder;
                }
            }
            return sum;
        }
    }
}
