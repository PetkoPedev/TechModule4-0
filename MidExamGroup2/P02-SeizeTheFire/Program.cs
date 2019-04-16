using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_SeizeTheFire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('#').ToArray();
            double waterAmount = double.Parse(Console.ReadLine());

            double effort = 0;

            var cellsToPutOut = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                string[] cell = input[i].Split(" = ").ToArray();
                string typeOfFire = cell[0];
                int waterForCell = int.Parse(cell[1]);

                bool isValid = false;

                if (typeOfFire == "High" && waterForCell >= 81 && waterForCell <= 125)
                {
                    isValid = true;
                }

                if (typeOfFire == "Medium" && waterForCell >= 51 && waterForCell <= 80)
                {
                    isValid = true;
                }

                if (typeOfFire == "Low" && waterForCell >= 1 && waterForCell <= 50)
                {
                    isValid = true;
                }

                if (isValid && waterAmount >= waterForCell)
                {
                    waterAmount -= waterForCell;
                    effort += waterForCell * 0.25;
                    cellsToPutOut.Add(waterForCell);
                }
            }

            Console.WriteLine("Cells:");
            foreach (var item in cellsToPutOut)
            {
                Console.WriteLine($" - {item}");
            }
            Console.WriteLine($"Effort: {effort:F2}");
            Console.WriteLine($"Total Fire: {cellsToPutOut.Sum()}");
        }
    }
}
