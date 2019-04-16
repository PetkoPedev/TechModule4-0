using System;
using System.Collections.Generic;

namespace P07_StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] tokens = input.Split();
                //{Serial Number} {Item Name} {Item Quantity} {itemPrice}

                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal itemPrice = decimal.Parse(tokens[3]);
                decimal priceOfBox = itemQuantity * itemPrice;
                
                input = Console.ReadLine();

                Box box = new Box();
                box.Item = new Item();

                box.SerialNumber = serialNumber;
                
                box.PriceBox = priceOfBox;
                box.Quantity = itemQuantity;

                boxes.Add(box);
            }

            foreach (var item in boxes)
            {
                Console.WriteLine(item.SerialNumber);
                Console.WriteLine($"-- {item.Item} – ${item.PriceBox}: {item.Quantity}");
                Console.WriteLine($"-- ${item.PriceBox}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox { get; set; }
    }
}
