using System;
using System.Collections.Generic;

namespace P02_RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ');
            var random = new Random();
            var shuffleWords = new List<string>();
            foreach (var word in words)
            {
                int nextIndex = random.Next(0, shuffleWords.Count + 1);
                shuffleWords.Insert(nextIndex, word);
            }

            foreach (var word in shuffleWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
