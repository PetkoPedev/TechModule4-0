using System;
using System.Text.RegularExpressions;

namespace P08_MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var numberStrings = Console.ReadLine();
            var numbers = Regex.Matches(numberStrings, regex);

            foreach (Match match in numbers)
            {
                Console.Write(match.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
