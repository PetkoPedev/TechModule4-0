using System;

namespace P01_DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string type;

            while (input != "END")
            {
                if (bool.TryParse(input, out bool boolean))
                {
                    type = "boolean";
                }
                else if (int.TryParse(input, out int integer))
                {
                    type = "integer";
                }
                else if (char.TryParse(input, out char character))
                {
                    type = "character";
                }
                else if (double.TryParse(input, out double floating))
                {
                    type = "floating point";
                }
                else
                {
                    type = "string";
                    
                }
                Console.WriteLine($"{input} is {type} type");
                input = Console.ReadLine();
            }
        }
    }
}
