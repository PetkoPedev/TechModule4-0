using System;
using System.Text.RegularExpressions;

namespace P01_TheIsleOfManRace
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([#$%*&])(?<name>[A-Za-z]+)\1=(?<length>\d+)!!(?<code>\w+)";
            bool isValid;
            MatchCollection matches = Regex.Matches(input, pattern);

            while (true)
            {
                foreach (Match m in matches)
                {
                    var name = m.Groups["name"].Value;
                    var length = m.Groups["length"].Value;
                    var encryptedCode = m.Groups["code"].Value;

                    int lengthOfCode = int.Parse(length);
                    int lengthOfEncryptedCode = encryptedCode.Length;

                    if (lengthOfCode != lengthOfEncryptedCode)
                    {
                        Console.WriteLine($"Nothing found!");
                        isValid = false;
                    }
                    else
                    {
                        string sumOfEncryptedCode = encryptedCode + lengthOfCode;
                        Console.WriteLine($"Coordinates found! {name} -> {sumOfEncryptedCode}");
                        isValid = true;
                        break;
                    }
                }
                input = Console.ReadLine();
            }

        }
    }
}
