using System;
using System.Linq;

namespace P09_KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int longestSubSequence = -1;
            int longestSubIndex = -1;
            int longestSubSum = -1;
            int indexOfLongest = 0;

            int[] sequence = new int[length];

            string input = Console.ReadLine();

            int indexOfSequence = 1;

            while (input != "Clone them!")
            {
                int[] currentSequence = input.Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int subSequence = -1;
                int subIndex = -1;
                int subSum = 0;

                int count = 0;
                for (int i = 0; i < length; i++)
                {
                    if (currentSequence[i] == 1)
                    {
                        count++;
                        subSum++;
                        if (count > subSequence)
                        {
                            subSequence = count;
                            subIndex = i - count;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }

                if (subSequence > longestSubSequence)
                {
                    longestSubIndex = subIndex;
                    longestSubSequence = subSequence;
                    longestSubSum = subSum;
                    sequence = currentSequence;
                    indexOfLongest = indexOfSequence;
                }
                else if (subSequence == longestSubSequence && longestSubIndex > subIndex)
                {
                    longestSubIndex = subIndex;
                    longestSubSum = subSum;
                    sequence = currentSequence;
                    indexOfLongest = indexOfSequence;
                }
                else if (subSequence == longestSubSequence && longestSubIndex == subIndex && longestSubSum < subSum)
                {
                    longestSubSum = subSum;
                    sequence = currentSequence;
                    indexOfLongest = indexOfSequence;
                }

                indexOfSequence++;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {indexOfLongest} with sum: {longestSubSum}.");
            Console.WriteLine(String.Join(" ", sequence));
        }
    }
}
