using System;

namespace P01_EasterCozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double floorOneKilo = double.Parse(Console.ReadLine());

            double eggsPack = floorOneKilo * 0.75;
            double milkPrice = (floorOneKilo * 1.25) / 4;
            double kozonacPrice = floorOneKilo + eggsPack + milkPrice;

            int kozonacCount = 0;
            int coloredEggs = 0;
            while (budget - kozonacPrice >= 0)
            {
                budget -= kozonacPrice;
                kozonacCount++;
                coloredEggs += 3;
                if (kozonacCount % 3 == 0)
                {
                    coloredEggs -= (kozonacCount - 2);
                }
            }

            Console.WriteLine($"You made {kozonacCount} cozonacs! Now you have {coloredEggs} eggs and {budget:F2}BGN left.");
        }
    }
}
