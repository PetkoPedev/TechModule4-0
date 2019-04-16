using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            var wordsInDict = new List<string>();
            var listOfWords = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(" | ");
                foreach (var item in tokens)
                {
                    string[] wordDeff = item.Split(": ");
                    string word = wordDeff[0];
                    if (!wordsInDict.Contains(word))
                    {
                        wordsInDict.Add(word);
                    }
                    string definition = wordDeff[1];

                    if (!dictionary.ContainsKey(word))
                    {
                        dictionary.Add(word, new List<string>());
                    }
                    dictionary[word].Add(definition);
                }

                string[] tokensOfWords = Console.ReadLine().Split(" | ");
                foreach (var item in tokensOfWords)
                {
                    if (!listOfWords.Contains(item))
                    {
                        listOfWords.Add(item);
                    }
                }

                string command = Console.ReadLine();

                if (command == "List")
                {
                    Console.WriteLine(string.Join(" ", wordsInDict.OrderBy(x => x)));
                    break;
                }
                else if (command == "End")
                {
                    foreach (var kvp in dictionary.OrderBy(x => x.Key))
                    {
                        if (listOfWords.Contains(kvp.Key))
                        {
                            Console.WriteLine($"{kvp.Key}");
                            Console.WriteLine($" -{string.Join(Environment.NewLine + " -", kvp.Value.OrderByDescending(x => x.Length))}");
                        }
                    }
                    break;
                }
            }
        }
    }
}
