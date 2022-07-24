using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Race
{
    public class Person
    {
        public string Name { get; set; }

        public int Distance { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> participantsList = new List<Person>();

            string[] participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string line = Console.ReadLine();

            while (line != "end of race")
            {
                string name = string.Empty;
                int distance = 0;

                for (int i = 0; i < line.Length; i++)
                {
                    char curr = line[i];

                    if (char.IsLetter(curr))
                    {
                        name += curr;
                    }

                    if (char.IsDigit(curr))
                    {
                        distance += curr - '0';
                    }
                }

                Person person = null;

                if (participants.Contains(name))
                {
                    if (participantsList.Any(p => p.Name == name))
                    {
                        person = participantsList.FirstOrDefault(p => p.Name == name);

                        participantsList.Remove(person);

                        person.Distance += distance;

                        participantsList.Add(person);
                    }
                    else
                    {
                        person = new Person()
                        {
                            Name = name,
                            Distance = distance,
                        };

                        participantsList.Add(person);
                    }

                }

                line = Console.ReadLine();
            }

            participantsList = participantsList
                .OrderByDescending(p => p.Distance)
                .Take(3)
                .ToList();

            Console.WriteLine($"1st place: {participantsList[0].Name}");
            Console.WriteLine($"2nd place: {participantsList[1].Name}");
            Console.WriteLine($"3rd place: {participantsList[2].Name}");
        }
    }
}