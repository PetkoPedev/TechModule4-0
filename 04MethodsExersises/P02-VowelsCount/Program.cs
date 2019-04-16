using System;

namespace P02_VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            int result = CountVowels(input);
            Console.WriteLine(result);
        }

        private static int CountVowels(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' ||
                    input[i] == 'e' ||
                    input[i] == 'o' ||
                    input[i] == 'u' ||
                    input[i] == 'i' ||
                    input[i] == 'y')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
