using System;

namespace P01_IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());
            int addition = firstNumber + secondNumber;
            int division = addition / thirdNumber;
            int multiplication = division * fourthNumber;
            Console.WriteLine(multiplication);
        }
    }
}
