using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                List<string> tokens = input.Split().ToList();
                if (tokens[0] == "Delete")
                {
                    int elementsToDelete = int.Parse(tokens[1]);
                    for (int i = 0; i < integers.Count; i++)
                    {
                        integers.RemoveAll(x => x == elementsToDelete);
                    }
                }
                else if (tokens[0] == "Insert")
                {
                    int element = int.Parse(tokens[1]);
                    int position = int.Parse(tokens[2]);
                    integers.Insert(position, element);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
