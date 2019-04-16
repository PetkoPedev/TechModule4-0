using System;
using System.Linq;

namespace P05_TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < integers.Length; i++)
            {
                bool isItBigger = true;
                for (int j = i + 1; j < integers.Length; j++)
                {
                    if (integers[i] <= integers[j])
                    {
                        isItBigger = false;
                    }
                }
                if (isItBigger)
                {
                    Console.Write(integers[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
