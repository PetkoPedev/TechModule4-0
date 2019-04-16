using System;
using System.Collections.Generic;
using System.Linq;

namespace P09_ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var forceBook = new Dictionary<string, List<string>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (input.Contains('|'))
                {
                    string[] tokens = input.Split(" | ");
                    string forceSide = tokens[0];
                    string forceUser = tokens[1];

                    if (!forceBook.ContainsKey(forceSide))
                    {
                        List<string> forceUsers = new List<string>();
                        forceUsers.Add(forceUser);
                        forceBook.Add(forceSide, forceUsers);
                    }
                    else if (!forceBook[forceSide].Contains(forceUser))
                    {
                        forceBook[forceSide].Add(forceUser);
                    }
                }

                if (input.Contains("->"))
                {
                    string[] tokens = input.Split(" -> ");
                    string forceUser = tokens[0];
                    string forceSide = tokens[1];

                    if (!forceBook.Any(x => x.Value.Contains(forceUser)))
                    {
                        if (!forceBook.ContainsKey(forceSide))
                        {
                            forceBook.Add(forceSide, new List<string>());
                        }
                        forceBook[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else
                    {
                        foreach (var s in forceBook)
                        {
                            if (s.Value.Contains(forceUser))
                            {
                                s.Value.Remove(forceUser);
                            }
                        }

                        if (!forceBook.ContainsKey(forceSide))
                        {
                            forceBook.Add(forceSide, new List<string>());
                        }
                        forceBook[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                }
            }

            foreach (var side in forceBook.Where(z => z.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var user in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
