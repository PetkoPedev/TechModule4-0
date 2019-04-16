using System;
using System.Collections.Generic;

namespace P02_OddOccurrencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordsInLowercase = word.ToLower();
                if (counts.ContainsKey(wordsInLowercase))
                {
                    counts[wordsInLowercase]++;
                }
                else
                {
                    counts.Add(wordsInLowercase, 1);
                }
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 == 1)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
