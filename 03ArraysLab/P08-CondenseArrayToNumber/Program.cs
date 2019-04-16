using System;
using System.Linq;

namespace P08_CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (arrayOfNumbers.Length > 1)
            {
                int[] condensedNumber = new int[arrayOfNumbers.Length - 1];
                for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
                {
                    condensedNumber[i] = arrayOfNumbers[i] + arrayOfNumbers[i + 1];
                }
                arrayOfNumbers = condensedNumber;
            }
            Console.WriteLine(arrayOfNumbers[0]);
        }
    }
}
