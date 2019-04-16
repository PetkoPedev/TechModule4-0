using System;

namespace P03_FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            double difference = Math.Abs(number1 - number2);
            const double eps = 0.000001;
            bool areDifferent = difference < eps;
            Console.WriteLine(areDifferent);
        }
    }
}
