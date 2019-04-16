using System;

namespace P01_SpringVacationTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfVacation = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int groupOfPeople = int.Parse(Console.ReadLine());
            double fuelPerKM = double.Parse(Console.ReadLine());
            double foodExpenses = double.Parse(Console.ReadLine());
            double roomPricePerNight = double.Parse(Console.ReadLine());

            double totalFoodExpenses = foodExpenses * daysOfVacation * groupOfPeople;
            double totalHotelExpenses = roomPricePerNight * groupOfPeople * daysOfVacation;

            if (groupOfPeople > 10)
            {
                double discount = totalHotelExpenses * 0.25;
                totalHotelExpenses -= discount;
            }

            double expensesVacation = totalFoodExpenses + totalHotelExpenses;
            

            for (int i = 1; i <= daysOfVacation; i++)
            {
                double travelledDistance = double.Parse(Console.ReadLine());
                double totalConsumedFuel = travelledDistance * fuelPerKM;

                expensesVacation += totalConsumedFuel;

                if (i % 3 == 0 || i % 5 == 0)
                {
                    expensesVacation += expensesVacation * 0.4;
                }

                if (i % 7 == 0)
                {
                    double withdraw = expensesVacation / groupOfPeople;
                    expensesVacation -= withdraw;
                }
            }

            if (budget > expensesVacation)
            {
                Console.WriteLine($"You have reached the destination. You have {budget - expensesVacation}$ budget left.");
            }
            else
            {
                Console.WriteLine($"Not enough money to continue the trip. You need {expensesVacation - budget}$ more.");
            }
        }
    }
}
