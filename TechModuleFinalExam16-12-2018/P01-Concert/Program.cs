using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bandAndMembers = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandOnStage = new Dictionary<string, int>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "start of concert")
            {
                string[] tokens = input.Split("; ");
                string command = tokens[0];
                if (command == "Add")
                {
                    string bandName = tokens[1];
                    var bandMembers = tokens[2].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    if (!bandAndMembers.ContainsKey(bandName))
                    {
                        bandAndMembers[bandName] = new List<string>();
                    }

                    for (int i = 0; i < bandMembers.Count; i++)
                    {
                        if (!bandAndMembers[bandName].Contains(bandMembers[i]))
                        {
                            bandAndMembers[bandName].Add(bandMembers[i]);
                        }
                    }
                }
                else if (command == "Play")
                {
                    string bandName = tokens[1];
                    int bandTime = int.Parse(tokens[2]);

                    if (!bandOnStage.ContainsKey(bandName))
                    {
                        bandOnStage[bandName] = 0;
                    }
                    bandOnStage[bandName] += bandTime;
                }
            }

            string band = Console.ReadLine();

            Console.WriteLine($"Total time: {bandOnStage.Values.Sum()}");
            foreach (var b in bandOnStage.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{b.Key} -> {b.Value}");
            }

            foreach (var kv in bandAndMembers)
            {
                if (kv.Key == band)
                {
                    Console.WriteLine($"{kv.Key}");
                    foreach (var item in kv.Value)
                    {
                        Console.WriteLine($"=> {item}");
                    }
                }
            }
        }
    }
}
