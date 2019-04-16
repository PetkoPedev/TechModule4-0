using System;

namespace P01_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            switch (dataType)
            {
                case "int":
                    int integerNumber = int.Parse(Console.ReadLine());
                    FindResult(integerNumber);
                    break;
                case "real":
                    double realNumber = double.Parse(Console.ReadLine());
                    FindResult(realNumber);
                    break;
                case "string":
                    string input = Console.ReadLine();
                    FindResult(input);
                    break;
                default:
                    break;
            }
        }

        private static void FindResult(int integerNumber)
        {
            int result = integerNumber * 2;
            Console.WriteLine(result);
        }
        private static void FindResult(double realNumber)
        {
            double result = realNumber * 1.5;
            Console.WriteLine($"{result:F2}");
        }

        private static void FindResult(string input)
        {
            Console.WriteLine($"${input}$");
        }
    }
}
