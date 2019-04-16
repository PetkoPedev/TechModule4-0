using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().Where(x => x != ' ').ToArray();

            var countChar = new Dictionary<char, int>();

            foreach (var character in text)
            {
                if (!countChar.ContainsKey(character))
                {
                    countChar[character] = 0;
                }
                countChar[character]++;
            }

            foreach (var item in countChar)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
