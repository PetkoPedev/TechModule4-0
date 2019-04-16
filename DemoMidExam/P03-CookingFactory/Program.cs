using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_CookingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split('#').Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "Bake It!")
            {
                List<int> breads = input.Split('#').Select(int.Parse).ToList();
                if (sequence.Sum() < breads.Sum())
                {
                    sequence = breads;
                }

                if (sequence.Sum() == breads.Sum() && sequence.Count > breads.Count)
                {
                    sequence = breads;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best Batch quality: {sequence.Sum()}");
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
