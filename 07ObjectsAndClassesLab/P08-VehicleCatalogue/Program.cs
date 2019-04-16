using System;
using System.Collections.Generic;

namespace P08_VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HoursePower { get; set; }
    }

    class CatalogueVehicle
    {

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
