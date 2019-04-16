using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictOfContests = new Dictionary<string, string>();
            string linesOfContests = Console.ReadLine();
            while (linesOfContests != "end of contests")
            {
                string[] tokens = linesOfContests.Split(':');
                string nameOfContest = tokens[0];
                string password = tokens[1];

                dictOfContests.Add(nameOfContest, password);

                linesOfContests = Console.ReadLine();
            }

            string lineOfSubmissions = Console.ReadLine();
            var dictOfSubmissions = new SortedDictionary<string, Dictionary<string, double>>();
            while (lineOfSubmissions != "end of submissions")
            {
                string[] tokens = lineOfSubmissions.Split("=>");
                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                double points = double.Parse(tokens[3]);

                if (!dictOfContests.ContainsKey(contest) || dictOfContests[contest] != password)
                {
                    lineOfSubmissions = Console.ReadLine();
                    continue;
                }

                if (!dictOfSubmissions.ContainsKey(username))
                {
                    dictOfSubmissions[username] = new Dictionary<string, double>();
                    
                }

                if (!dictOfSubmissions[username].ContainsKey(contest))
                {
                    dictOfSubmissions[username].Add(contest, points);
                }

                if (dictOfSubmissions[username][contest] < points)
                {
                    dictOfSubmissions[username][contest] = points;
                }

                lineOfSubmissions = Console.ReadLine();
            }

            Dictionary<string, double> usernameTotalPoints = new Dictionary<string, double>();
            foreach (var item in dictOfSubmissions)
            {
                usernameTotalPoints[item.Key] = item.Value.Values.Sum();
            }

            string bestCandidate = usernameTotalPoints.Keys.Max();

            double bestPoints = usernameTotalPoints.Values.Max();

            foreach (var kvp in usernameTotalPoints)
            {
                if (kvp.Value == bestPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");
                }
            }

            Console.WriteLine("Ranking:");
            foreach (var k in dictOfSubmissions)
            {
                Console.WriteLine(k.Key);
                Console.WriteLine(string.Join(Environment.NewLine, k.Value
                    .OrderByDescending(x => x.Value)
                    .Select(a => $"#  {a.Key} -> {a.Value}")
                    ));
            }
        }
    }
}
