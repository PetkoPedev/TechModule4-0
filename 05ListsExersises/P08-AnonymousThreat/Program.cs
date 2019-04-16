using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] tokens = input.Split().ToArray();

                string command = tokens[0];

                switch (command)
                {
                    case "merge":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);

                        if (endIndex < 0 || startIndex > words.Count - 1)
                        {
                            continue;
                        }
                        if (startIndex < 0)
                        {
                            startIndex = 0;
                        }
                        if (endIndex >= words.Count)
                        {
                            endIndex = words.Count - 1;
                        }

                        string concatWord = "";
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            concatWord += words[i];
                        }

                        words.RemoveRange(startIndex, endIndex - startIndex + 1);
                        words.Insert(startIndex, concatWord);
                        break;
                    case "divide":
                        int index = int.Parse(tokens[1]);
                        int partitions = int.Parse(tokens[2]);

                        string element = words[index];
                        int partLength = element.Length / partitions;
                        List<string> newWords = new List<string>();

                        for (int i = 0; i < partitions; i++)
                        {
                            if (i == partitions - 1)
                            {
                                newWords.Add(element);
                                break;
                            }
                            string word = element.Substring(0, partLength);
                            element = element.Substring(partLength);
                            newWords.Add(word);
                        }

                        words.RemoveAt(index);
                        words.InsertRange(index, newWords);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
