using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_BreadFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] events = Console.ReadLine().Split('|').ToArray();
            int initialEnergy = 100;
            int initialCoins = 100;
            bool success = true;
            for (int i = 0; i < events.Length; i++)
            {
                string[] currentEvent = events[i].Split('-').ToArray();
                string command = currentEvent[0];

                if (command == "rest")
                {
                    int energyToGain = int.Parse(currentEvent[1]);
                    if (initialEnergy + energyToGain < 100)
                    {
                        initialEnergy += energyToGain;
                        Console.WriteLine($"You gained {energyToGain} energy.");
                    }
                    else
                    {
                        Console.WriteLine("You gained 0 energy.");
                    }
                    Console.WriteLine($"Current energy: {initialEnergy}.");
                }
                else if (command == "order")
                {
                    int coinsToGain = int.Parse(currentEvent[1]);
                    initialEnergy -= 30;

                    if (initialEnergy >= 0)
                    {
                        initialCoins += coinsToGain;
                        Console.WriteLine($"You earned {coinsToGain} coins.");
                    }
                    else
                    {
                        initialEnergy += 80;
                        Console.WriteLine("You had to rest!");
                    }
                }
                else
                {
                    int ingredientsPrice = int.Parse(currentEvent[1]);
                    initialCoins -= ingredientsPrice;

                    if (initialCoins >= 0)
                    {
                        Console.WriteLine($"You bought {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {command}.");
                        success = false;
                        return;
                    }
                }
            }

            if (success)
            {
                Console.WriteLine("Day completed!");
                Console.WriteLine($"Coins: {initialCoins}");
                Console.WriteLine($"Energy: {initialEnergy}");
            }
        }
    }
}
