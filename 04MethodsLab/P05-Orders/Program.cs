using System;

namespace P05_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculateOrder(product, quantity);
        }

        static void CalculateOrder(string product, int quantity)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    Console.WriteLine("{0:F2}", quantity * price);
                    break;
                case "water":
                    price = 1.00;
                    Console.WriteLine("{0:F2}", quantity * price);
                    break;
                case "coke":
                    price = 1.40;
                    Console.WriteLine("{0:F2}", quantity * price);
                    break;
                case "snacks":
                    price = 2.00;
                    Console.WriteLine("{0:F2}", quantity * price);
                    break;
            }
        }
    }
}
