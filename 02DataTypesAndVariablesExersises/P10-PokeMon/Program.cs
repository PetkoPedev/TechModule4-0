using System;

namespace P10_PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int targetCounter = 0;

            decimal halfPower = pokePower * 0.5m;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                targetCounter++;

                if (pokePower == halfPower && exhaustionFactor > 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetCounter);
        }
    }
}
