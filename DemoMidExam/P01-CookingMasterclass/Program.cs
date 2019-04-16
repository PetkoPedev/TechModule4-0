using System;

namespace P01_CookingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal priceOfFlourPerPack = decimal.Parse(Console.ReadLine());
            decimal priceOfEgg = decimal.Parse(Console.ReadLine());
            decimal priceOfApron = decimal.Parse(Console.ReadLine());
            
            decimal freeFlourPack = students / 5;
            
            decimal totalFlourPrice = (students - freeFlourPack) * priceOfFlourPerPack;
            decimal eggsPrice = students * priceOfEgg * 10;
            decimal totalPriceOfAprons = (decimal)Math.Ceiling(students * 1.2) * priceOfApron;

            decimal totalExp = totalFlourPrice + eggsPrice + totalPriceOfAprons;

            if (budget >= totalExp)
            {
                Console.WriteLine($"Items purchased for {totalExp:F2}$.");
            }
            else
            {
                Console.WriteLine($"{(totalExp - budget):F2}$ more needed.");
            }
            //Console.WriteLine(totalExp);
        }
    }
}
