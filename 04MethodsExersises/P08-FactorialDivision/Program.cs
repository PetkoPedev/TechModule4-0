using System;

namespace P08_FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            
            double factorialOfFirstInteger = CalculateFactorial(firstNumber);
            double factorialOfSecondInteger = CalculateFactorial(secondNumber);
            
            double result = factorialOfFirstInteger / factorialOfSecondInteger;

            Console.WriteLine($"{result:F2}");
        }

        private static double CalculateFactorial(double number)
        {
            double factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
