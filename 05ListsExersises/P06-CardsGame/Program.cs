using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> deck2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            int count = 0;
            while (true)
            {
                if (deck1[count] > deck2[count])
                {
                    deck1.Add(deck1[count]);
                    deck1.Add(deck2[count]);
                    deck1.RemoveAt(count);
                    deck2.RemoveAt(count);
                }
                else if (deck1[count] < deck2[count])
                {
                    deck2.Add(deck2[count]);
                    deck2.Add(deck1[count]);
                    deck2.RemoveAt(count);
                    deck1.RemoveAt(count);
                }
                else
                {
                    deck1.RemoveAt(count);
                    deck2.RemoveAt(count);
                }

                if (deck1.Count == 0 || deck2.Count == 0)
                {
                    break;
                }
            }

            if (deck1.Sum() > deck2.Sum())
            {
                Console.WriteLine($"First player wins! Sum: {deck1.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {deck2.Sum()}");
            }
        }
    }
}
