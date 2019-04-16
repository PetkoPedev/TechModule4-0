using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, Dictionary<string, int>>();
            string input = "";

            while ((input = Console.ReadLine()) != "Season end")
            {
                List<string> inputType = new List<string>();
                if (input.Contains("->"))
                {
                    inputType = input.Split(" -> ").ToList();
                }
                else if (input.Contains("vs"))
                {
                    inputType = input.Split(" vs ").ToList();
                }

                if (inputType.Count == 3)
                {
                    string playerName = inputType[0];
                    string position = inputType[1];
                    int skill = int.Parse(inputType[2]);
                    if (!players.ContainsKey(playerName))
                    {
                        players.Add(playerName, new Dictionary<string, int>());
                    }
                    if (!players[playerName].ContainsKey(position))
                    {
                        players[playerName].Add(position, skill);
                    }
                    else
                    {
                        if (skill > players[playerName][position])
                        {
                            players[playerName][position] = skill;
                        }
                    }
                }
                else if (inputType.Count == 2)
                {
                    string firstPlayer = inputType[0];
                    string secondPlayer = inputType[1];
                    if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
                    {
                        string[] firstPlayerPositions = players[firstPlayer].Keys.ToArray();
                        foreach (var pos2 in players[secondPlayer].Keys)
                        {
                            if (firstPlayerPositions.Contains(pos2))
                            {
                                int totalSkillsFirstPlayer = players[firstPlayer].Values.Sum();
                                int totalSkillsSecondPlayer = players[secondPlayer].Values.Sum();
                                if (totalSkillsFirstPlayer > totalSkillsSecondPlayer)
                                {
                                    players.Remove(secondPlayer);
                                    break;
                                }
                                else if (totalSkillsFirstPlayer<totalSkillsSecondPlayer)
                                {
                                    players.Remove(firstPlayer);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            foreach (var p in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{p.Key}: {p.Value.Values.Sum()} skill");
                foreach (var pos in p.Value.OrderByDescending(s => s.Value).ThenBy(n => n.Key))
                {
                    Console.WriteLine($"- {pos.Key} <::> {pos.Value}");
                }
            }
        }
    }
}
