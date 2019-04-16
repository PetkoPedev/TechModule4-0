using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_PracticeSession
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> roadData = new Dictionary<string, List<string>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split("->");
                string command = tokens[0];
                if (command == "Add")
                {
                    string road = tokens[1];
                    string racer = tokens[2];
                    if (!roadData.ContainsKey(road))
                    {
                        roadData.Add(road, new List<string>());
                    }
                    roadData[road].Add(racer);
                }
                else if (command == "Move")
                {
                    string oldRoad = tokens[1];
                    string racer = tokens[2];
                    string newRoad = tokens[3];

                    if (roadData[oldRoad].Contains(racer))
                    {
                        roadData[oldRoad].Remove(racer);
                        roadData[newRoad].Add(racer);
                    }

                }
                else if (command == "Close")
                {
                    string roadToRemove = tokens[1];
                    if (roadData.ContainsKey(roadToRemove))
                    {
                        roadData.Remove(roadToRemove);
                    }
                }
            }

            Console.WriteLine("Practice sessions:");
            foreach (var ro in roadData.OrderByDescending(r => r.Value.Count).ThenBy(r => r.Key))
            {
                Console.WriteLine($"{ro.Key}");
                foreach (var r in ro.Value)
                {
                    Console.WriteLine($"++{r}");
                }
            }
        }
    }
}
