using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_FinalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(" ").ToList();
            string command = Console.ReadLine();

            while (command != "Stop")
            {
                var tokens = command.Split(" ").ToList();

                if (tokens[0] == "Delete")
                {
                    int indexFirst = int.Parse(tokens[1]) + 1;

                    if (indexFirst> -1 && indexFirst<=words.Count - 1)
                    {
                        words.RemoveAt(indexFirst);
                    }
                }
                else if (tokens[0] == "Swap")
                {
                    string firstWord = tokens[1];
                    string secondWord = tokens[2];

                    if (words.Contains(firstWord) && words.Contains(secondWord))
                    {
                        int indexFirst = words.IndexOf(firstWord);
                        int indexSecond = words.IndexOf(secondWord);

                        words[indexFirst] = secondWord;
                        words[indexSecond] = firstWord;
                    }
                }
                else if (tokens[0] == "Put")
                {
                    string word = tokens[1];
                    int indexFirst = int.Parse(tokens[2]) - 1;
                    if (indexFirst > 0 && indexFirst <= words.Count + 1)
                    {
                        words.Insert(indexFirst, word);
                    }
                }
                else if (tokens[0] == "Sort")
                {
                    words.Sort();
                    words.Reverse();
                }
                else if (tokens[0] == "Replace")
                {
                    string firstWord = tokens[1];
                    string secondWord = tokens[2];
                    if (words.Contains(secondWord))
                    {
                        int firstIndex = words.IndexOf(secondWord);
                        words.RemoveAt(firstIndex);
                        words.Insert(firstIndex, firstWord);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", words));
        }
    }
}
