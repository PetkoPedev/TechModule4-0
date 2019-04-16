using System;
using System.Linq;

namespace P01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] passengers = new int[wagons];

            for (int i = 0; i < wagons; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
            }
            sum = passengers.Sum();
            
            Console.WriteLine(String.Join(" ", passengers));
            Console.WriteLine(sum);
        }
    }
}
