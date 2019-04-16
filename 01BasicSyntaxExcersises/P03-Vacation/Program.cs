using System;

namespace P03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;

            if (groupType == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (groupType == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 16;
                }
            }
            else if (groupType == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 22.5;
                }
            }

            if (groupType == "Students" && groupSize >= 30)
            {
                price = price - (price * 0.15);
            }

            if (groupType == "Business" && groupSize >= 100)
            {
                groupSize -= 10;
            }

            if (groupType == "Regular" && (groupSize >= 10 && groupSize <= 20))
            {
                price -= price * 0.05;
            }

            Console.WriteLine($"Total price: {groupSize * price:F2}");
        }
    }
}
