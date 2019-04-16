using System;

namespace P01_PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            double lightsabersMoney = lightsabers * Math.Ceiling((double)(students) * 1.1);
            double robesMoney = robes * students;
            double beltsMoney = belts * (students - students / 6);

            double totalMoney = lightsabersMoney + robesMoney + beltsMoney;

            if (totalMoney > money)
            {
                Console.WriteLine($"Ivan Cho will need {totalMoney - money:F2}lv more.");
            }
            else
                Console.WriteLine($"The money is enough - it would cost {totalMoney:F2}lv.");
        }
    }
}
