using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();
            List<int> resultList = new List<int>();

            Console.WriteLine();

            foreach (var number in input)
            {
                resultList.AddRange(number.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.Write(string.Join(" ", resultList));
        }
    }
}