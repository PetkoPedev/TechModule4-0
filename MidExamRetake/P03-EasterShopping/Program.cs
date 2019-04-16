using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_EasterShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            var shops = Console.ReadLine().Split().ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                if (command == "Include")
                {
                    string shopName = input[1];
                    shops.Add(shopName);
                }

                if (command == "Visit")
                {
                    string firstOrLast = input[1];
                    int numberOfShops = int.Parse(input[2]);
                    if (shops.Count >= numberOfShops)
                    {
                        if (firstOrLast == "first")
                        {
                            shops.RemoveRange(0, numberOfShops);
                        }
                        else if (firstOrLast == "last")
                        {
                            int firstIndex = shops.Count - numberOfShops;
                            shops.RemoveRange(firstIndex, numberOfShops);
                        }
                    }
                }

                if (command == "Prefer")
                {
                    int shopIndex1 = int.Parse(input[1]);
                    int shopIndex2 = int.Parse(input[2]);

                    if (shopIndex1 >= 0 && shopIndex1 <= shops.Count - 1 && shopIndex2 >= 0 && shopIndex2 <= shops.Count - 1)
                    {
                        string temp = shops[shopIndex1];
                        shops[shopIndex1] = shops[shopIndex2];
                        shops[shopIndex2] = temp;
                    }
                }

                if (command == "Place")
                {
                    string shopToPlace = input[1];
                    int shopIndex = int.Parse(input[2]);
                    if (shopIndex >= 0 && shopIndex < shops.Count - 1)
                    {
                        shops.Insert(shopIndex + 1, shopToPlace);
                    }
                }
            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shops));
        }
    }
}
