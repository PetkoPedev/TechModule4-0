using System;

namespace P07_RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(input, counter));
        }

        private static string RepeatString(string input, int counter)
        {
            string result = "";

            for (int i = 0; i < counter; i++)
            {
                result += input;
            }

            return result;
        }
    }
}
