using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Judge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests =
                new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, Dictionary<string, int>> usersContestsPoints =
                new Dictionary<string, Dictionary<string, int>>();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "no more time")
            {
                string[] cmdArgs = line
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string username = cmdArgs[0];
                string contest = cmdArgs[1];
                int points = int.Parse(cmdArgs[2]);

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, new Dictionary<string, int>());
                }

                if (!usersContestsPoints.ContainsKey(username))
                {
                    usersContestsPoints.Add(username, new Dictionary<string, int>());
                }

                if (!contests[contest].ContainsKey(username))
                {
                    contests[contest].Add(username, points);

                    if (!usersContestsPoints[username].ContainsKey(contest))
                    {
                        usersContestsPoints[username].Add(contest, points);
                    }
                }
                else
                {
                    int previousUserPoints = contests[contest][username];
                    int maxPointsForCurrentContest = Math.Max(points, previousUserPoints);

                    contests[contest][username] = maxPointsForCurrentContest;
                    usersContestsPoints[username][contest] = maxPointsForCurrentContest;
                }
            }

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                int rankingPlace = 1;

                foreach (var user in contest.Value.OrderByDescending(u => u.Value).ThenBy(u => u.Key))
                {
                    Console.WriteLine($"{rankingPlace}. {user.Key} <::> {user.Value}");
                    rankingPlace++;
                }
            }

            Console.WriteLine("Individual standings:");

            int position = 1;

            foreach (var user in usersContestsPoints.OrderByDescending(u => u.Value.Sum(c => c.Value)).ThenBy(u => u.Key))
            {
                var userTotalPoints = user.Value.Sum(c => c.Value);

                Console.WriteLine($"{position}. {user.Key} -> {userTotalPoints}");
                position++;
            }
        }
    }
}