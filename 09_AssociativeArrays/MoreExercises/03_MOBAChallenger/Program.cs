using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MOBAChallenger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playersStats =
                new Dictionary<string, Dictionary<string, int>>();

            string player = string.Empty;
            string position = string.Empty;
            int skill = 0;

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Season end")
            {
                string[] input = line
                    .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                if (!input.Contains("vs"))
                {
                    player = input[0];
                    position = input[1];
                    skill = int.Parse(input[2]);

                    if (playersStats.ContainsKey(player))
                    {
                        if (playersStats[player].ContainsKey(position))
                        {
                            if (playersStats[player][position] < skill)
                            {
                                playersStats[player][position] = skill;
                            }
                        }
                        else
                        {
                            playersStats[player][position] = skill;
                        }
                    }
                    else
                    {
                        Dictionary<string, int> assistDic = new Dictionary<string, int>();
                        assistDic.Add(position, skill);
                        playersStats[player] = assistDic;
                    }
                }
                else
                {
                    string playerOne = input[0];
                    string playerTwo = input[2];

                    if (playersStats.ContainsKey(playerOne) && playersStats.ContainsKey(playerTwo))
                    {
                        string playerToRemove = string.Empty;

                        foreach (var role in playersStats[playerOne])
                        {
                            foreach (var pos in playersStats[playerTwo])
                            {
                                if (role.Key == pos.Key)
                                {
                                    if (playersStats[playerOne].Sum(p => p.Value) > playersStats[playerTwo].Sum(p => p.Value))
                                    {
                                        playerToRemove = playerTwo;
                                    }
                                    else if (playersStats[playerOne].Sum(player => player.Value) < playersStats[playerTwo].Sum(p => p.Value))
                                    {
                                        playerToRemove = playerOne;
                                    }
                                }
                            }
                        }

                        playersStats.Remove(playerToRemove);
                    }
                }
            }

            foreach (var playerInfo in playersStats.OrderByDescending(p => p.Value.Sum(p => p.Value)).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{playerInfo.Key}: {playerInfo.Value.Sum(p => p.Value)} skill");

                foreach (var pair in playerInfo.Value.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
                {
                    Console.WriteLine($"- {pair.Key} <::> {pair.Value}");
                }
            }
        }
    }
}