using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_TeamworkProjects
{       
    public class Member
    {
        public Member(string name)
        {
            this.Name = name;
            this.HasJoined = false;
        }

        public string Name { get; set; }

        public bool HasJoined { get; set; }
    }

    public class Team
    {
        public Team(string teamName, Member creator)
        {
            this.TeamName = teamName;
            this.Creator = creator;
            this.Members = new List<Member>();
        }

        public string TeamName { get; set; }

        public Member Creator { get; set; }

        public List<Member> Members { get; set; }

        public bool IsDisband => this.Members.Count < 1;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.TeamName}");
            sb.AppendLine($"- {this.Creator.Name}");

            foreach (var member in this.Members.OrderBy(m => m.Name))
            {
                sb.AppendLine($"-- {member.Name}");
            }

            return sb.ToString().TrimEnd();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            List<Member> members = new List<Member>();
            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] creatorTeamInfo = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries);

                string creatorName = creatorTeamInfo[0];
                string teamName = creatorTeamInfo[1];

                if (teams.Count > 0)
                {
                    if (teams.Any(t => t.TeamName == teamName))
                    {
                       Console.WriteLine($"Team {teamName} was already created!");
                       continue;
                    }

                    if (teams.Any(t => t.Creator.Name == creatorName))
                    {
                       Console.WriteLine($"{creatorName} cannot create another team!");
                       continue;
                    }
                }

                Member creator = new Member(creatorName);
                members.Add(creator);
                Team team = new Team(teamName, creator);
                creator.HasJoined = true;
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "end of assignment")
            {
                string[] userTeamInfo = line
                    .Split("->", StringSplitOptions.RemoveEmptyEntries);

                string userName = userTeamInfo[0];
                string teamName = userTeamInfo[1];
                
                Team team = teams.FirstOrDefault(t => t.TeamName == teamName);

                if (team == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                Member member = members.FirstOrDefault(m => m.Name == userName);

                if (member != null)
                {
                    if (member.HasJoined)
                    { 
                       Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                       continue;
                    }
                }

                member = new Member(userName);
                members.Add(member);
                team.Members.Add(member);
                member.HasJoined = true;
            }

            List<Team> validTeams = teams
                .Where(t => t.IsDisband == false)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.TeamName)
                .ToList();

            List<Team> disbannedTeams = teams
                .Where(t => t.IsDisband)
                .OrderBy(t => t.TeamName)
                .ToList();

            foreach (var team in validTeams)
            {
                Console.WriteLine(team.ToString());
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in disbannedTeams)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
}