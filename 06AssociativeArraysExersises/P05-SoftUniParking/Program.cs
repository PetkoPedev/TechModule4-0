using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkingLotUsers = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                
                if (command == "register")
                {
                    string userName = input[1];
                    string licensePlateNumber = input[2];
                    if (!parkingLotUsers.ContainsValue(licensePlateNumber) || !parkingLotUsers.ContainsKey(userName))
                    {
                        parkingLotUsers.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }

                if (command == "unregister")
                {
                    string userName = input[1];
                    if (!parkingLotUsers.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        parkingLotUsers.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }
            }

            foreach (var kvp in parkingLotUsers)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
