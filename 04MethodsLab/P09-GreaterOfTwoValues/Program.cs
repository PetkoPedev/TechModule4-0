using System;

namespace P09_GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                GetMax(first, second);
            }

            if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                GetMax(first, second);
            }

            if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                GetMax(first, second);
            }

        }

        static void GetMax(int first, int second)
        {
            if (first > second)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }

        static void GetMax(char first, char second)
        {
            if (first > second)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }

        static void GetMax(string first, string second)
        {
            Console.WriteLine(first.CompareTo(second) > 0 ?
                first :
                second
                );
        }
    }
}
