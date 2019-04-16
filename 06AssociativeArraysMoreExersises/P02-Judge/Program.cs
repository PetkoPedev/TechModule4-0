using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contestantsAndPoints = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> individualStatistics = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "no more time")
            {
                string[] tokens = input.Split(" -> ");
                string userName = tokens[0];
                string contestName = tokens[1];
                int points = int.Parse(tokens[2]);

                if (!contestantsAndPoints.ContainsKey(userName))
                {
                    contestantsAndPoints.Add(userName, new Dictionary<string, int>());
                    contestantsAndPoints[userName].Add(contestName, points);
                }

                if (!contestantsAndPoints[userName].ContainsKey(contestName))
                {
                    contestantsAndPoints[userName].Add(contestName, points);
                }

                if (contestantsAndPoints[userName][contestName] < points)
                {
                    contestantsAndPoints[userName][contestName] = points;
                }
                
                if (!individualStatistics.ContainsKey(contestName))
                {
                    individualStatistics.Add(userName, new Dictionary<string, int>());
                }

                if (!individualStatistics[contestName].ContainsKey(userName))
                {
                    individualStatistics[contestName].Add(userName, 0);
                }

                if (individualStatistics[contestName][userName] < points)
                {
                    individualStatistics[contestName][userName] = points;
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in contestantsAndPoints)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} participants");
                int counter = 0;
                foreach (var item in kvp.Value.OrderByDescending(x => x.Value))
                {
                    counter++;
                    Console.WriteLine($"{counter}. {item.Key} <::> {item.Value}");
                }
            }
        }
    }
}
