using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P04_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, double[]>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "buy")
                {
                    break;
                }

                string[] inputProduct = input.Split().ToArray();
                string product = inputProduct[0];
                double price = double.Parse(inputProduct[1]);
                double quantity = double.Parse(inputProduct[2]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, new double[2]);
                }

                products[product][0] = price;
                products[product][1] += quantity;
            }

            foreach (var kvp in products)
            {
                Console.WriteLine($"{kvp.Key} -> {(kvp.Value[0] * kvp.Value[1]):F2}");
            }
        }
    }
}
