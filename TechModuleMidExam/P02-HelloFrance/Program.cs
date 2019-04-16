using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_HelloFrance
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new List<double>();
            double profit = 0;

            string[] input = Console.ReadLine().Split("|");
            double budget = double.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                string[] tokens = input[i].Split("->");
                string item = tokens[0];
                double priceOfItem = double.Parse(tokens[1]);

                switch (item)
                {
                    case "Clothes":
                        if (priceOfItem <= 50.00 && budget - priceOfItem >= 0)
                        {
                            budget -= priceOfItem;
                            profit += priceOfItem * 0.40;
                            result.Add(priceOfItem * 1.40);
                        }
                        break;
                    case "Shoes":
                        if (priceOfItem <= 35.00 && budget - priceOfItem >= 0)
                        {
                            budget -= priceOfItem;
                            profit += priceOfItem * 0.40;
                            result.Add(priceOfItem * 1.40);
                        }
                        break;
                    case "Accessories":
                        if (priceOfItem <= 20.50 && budget - priceOfItem >= 0)
                        {
                            budget -= priceOfItem;
                            profit += priceOfItem * 0.40;
                            result.Add(priceOfItem * 1.40);
                        }
                        break;
                    default:
                        break;
                }
            }

            foreach (var item in result)
            {
                Console.Write($"{item:F2} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Profit: {profit:F2}");

            if (budget + result.Sum() >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
