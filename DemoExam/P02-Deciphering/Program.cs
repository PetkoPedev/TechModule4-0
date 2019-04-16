using System;
using System.Text;

namespace P02_Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] command = Console.ReadLine().Split(" ");
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!((input[i] >= 100 && input[i] <= 125) || input[i] == 35))
                {
                    Console.WriteLine("This is not the book you are looking for.");
                    return;
                }
                count++;
            }
            StringBuilder result = new StringBuilder();
            for (int j = 0; j < input.Length; j++)
            {
                result.Append((char)((int)input[j] - 3));
            }
            result = result.Replace(command[0], command[1]);
            Console.WriteLine(result);
        }
    }
}
