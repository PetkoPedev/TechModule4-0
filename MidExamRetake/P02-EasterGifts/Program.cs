using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_EasterGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gifts = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();
            while (input != "No Money")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                if (command == "OutOfStock")
                {
                    string giftName = tokens[1];
                    for (int i = 0; i < gifts.Count; i++)
                    {
                        if (gifts.Contains(giftName))
                        {
                            int index = gifts.IndexOf(giftName);
                            gifts.RemoveAt(index);
                            gifts.Insert(index, "None");
                        }
                    }                   
                }

                if (command == "Required")
                {
                    string giftName = tokens[1];
                    int index = int.Parse(tokens[2]);
                    if (index > 0 && index <= gifts.Count -1)
                    {
                        gifts.RemoveAt(index);
                        gifts.Insert(index, giftName);
                    }
                }

                if (command == "JustInCase")
                {
                    string giftName = tokens[1];
                    string lastGift = gifts.LastOrDefault();
                    gifts.Remove(lastGift);
                    gifts.Add(giftName);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", gifts.Where(x => x != "None")));
        }
    }
}
