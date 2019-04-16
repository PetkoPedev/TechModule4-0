using System;

namespace P01_TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfAdventure = int.Parse(Console.ReadLine());
            int playersCount = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            double totalWater = daysOfAdventure * playersCount * water;
            double totalFood = daysOfAdventure * playersCount * food;

            for (int i = 1; i <= daysOfAdventure; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                groupEnergy -= energyLoss;

                if (groupEnergy <= 0)
                {
                    break;
                }

                if (i % 2 == 0)
                {
                    groupEnergy *= 1.05;
                    totalWater *= 0.70;
                }

                if (i % 3 == 0)
                {
                    groupEnergy *= 1.1;
                    
                    totalFood -= totalFood / playersCount;
                }
            }

            if (groupEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:F2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {(totalFood):F2} food and {(totalWater):F2} water.");
            }
        }
    }
}
