using System;
using System.Linq;

namespace P02_CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split().ToArray();

            string[] secondArr = Console.ReadLine().Split().ToArray();

            for (int i = 0; i <= secondArr.Length - 1; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (secondArr[i] == firstArr[j])
                    {
                        Console.Write($"{secondArr[i]} ");
                    }
                }
            }
        }
    }
}
