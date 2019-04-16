using System;

namespace P09_PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                bool isPalindrome = IsPalindrome(input);
                if (isPalindrome)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                //Console.WriteLine(isPalindrome);
                input = Console.ReadLine();
            }
        }
        static bool IsPalindrome(string str)
        {
            if (str.Length == 1 || str.Length == 0)
                return true;

            return str[0] == str[str.Length - 1] && IsPalindrome(str.Substring(1, str.Length - 2));
        }
    }
}
