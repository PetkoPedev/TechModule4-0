using System;
using System.Linq;

namespace P05_DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] digits = input.Where(x => char.IsDigit(x))
                                  .ToArray();

            char[] letters = input.Where(x => char.IsLetter(x))
                                 .ToArray();

            char[] other = input.Where(x => !char.IsLetterOrDigit(x))
                               .ToArray();

            Console.WriteLine(string.Join("", digits));
            Console.WriteLine(string.Join("", letters));
            Console.WriteLine(string.Join("", other));
        }
    }
}
