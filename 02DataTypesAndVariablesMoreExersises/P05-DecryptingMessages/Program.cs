using System;

namespace P05_DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            string message = "";

            while (lines > 0)
            {
                message += ((char)(char.Parse(Console.ReadLine()) + key)).ToString();

                lines--;
            }

            Console.WriteLine(message);
        }
    }
}
