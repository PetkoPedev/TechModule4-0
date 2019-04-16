using System;

namespace P05_AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int summedNumbers = Add(firstNumber, secondNumber);
            int finalResult = Substract(summedNumbers, thirdNumber);
            Console.WriteLine(finalResult);
        }

        static int Substract(int summedNumbers, int thirdNumber)
        {
            return summedNumbers - thirdNumber;
        }

        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
