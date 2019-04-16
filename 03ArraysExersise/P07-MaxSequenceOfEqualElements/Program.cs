using System;
using System.Linq;

namespace P07_MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var bestIndex = 0;
            var bestLength = 1;

            var currentIndex = 0;
            var currentLength = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i -1])
                {
                    currentLength++;

                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestIndex = currentIndex;
                    }
                }
                else
                {
                    currentIndex = i;
                    currentLength = 1;
                }
            }

            for (int i = bestIndex; i < bestIndex + bestLength; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
