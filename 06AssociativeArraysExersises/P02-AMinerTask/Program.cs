using System;
using System.Collections.Generic;

namespace P02_AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(line))
                {
                    resources[line] = quantity;
                }
                else
                {
                    resources[line] += quantity;
                }
            }

            foreach (var res in resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
