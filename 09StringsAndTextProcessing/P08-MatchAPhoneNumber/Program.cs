using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P08_MatchAPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string regex = @"(?<!\d)[+]359([ -])2\1\d{3}\1\d{4}\b";

            List<string> phones = new List<string>();
            MatchCollection match = Regex.Matches(numbers, regex);

            foreach (Match number in match)
            {
                phones.Add(number.Value);
            }

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
